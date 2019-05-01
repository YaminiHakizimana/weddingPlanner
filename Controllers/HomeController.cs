using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    {
        private UserContext dbContext;
        public HomeController(UserContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {

                if(dbContext.users.Any(u => u.Email == user.Email) )
                {
                    ModelState.TryAddModelError("Email", "Email already in use!");
                    ViewBag.DuplicatateMessage = "Email already in use";
                    return View("index");
                }
                else
                {

                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.users.Add(user);
                    dbContext.SaveChanges();

                    return RedirectToAction("Index");
                }
            }
            return View("index");
        }    
        
        

        [HttpPost("Submit")]    

        public IActionResult Submit(string Email, string Password)
        {
            if(ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.users.FirstOrDefault(u => u.Email ==  Email);
                // If no user exists with provided email
                if(userInDb == null || Password == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Email", "Invalid Email");
                    return View("Index");
                }
               
                {
                    var hasher = new PasswordHasher<User>();
                    
                    // varify provided password against hash stored in db
                    var result = hasher.VerifyHashedPassword(userInDb, userInDb.Password, Password);
                    
                    // result can be compared to 0 for failure
                    if(result == 0)
                    {
                        ModelState.AddModelError("Password", "Invalid Password");
                        return View("Index");
                    }
                    
                
        
                } 
                HttpContext.Session.SetInt32("Id",userInDb.UserId);
                // ViewBag.show="Succesfuly created your Email";

                return RedirectToAction("dashboard");
     
            }
            return View("Index");
        }

        [Route("log_out")]
        [HttpGet]
        public IActionResult log_out()
        {
           
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
        [Route("dashboard")]
        [HttpGet]
        public IActionResult dashboard()
        {
           var Key= HttpContext.Session.GetInt32("Id");
            
            System.Console.WriteLine(Key);
            if(Key==null){
               return RedirectToAction("Index");
            }
            User Uzer = dbContext.users.SingleOrDefault(user => user.UserId == HttpContext.Session.GetInt32("Id"));
            List<Wedding> Allinvites = dbContext.wedding
            .Include(a=>a.Users)
            .ThenInclude(b=>b.Auser)
            .ToList();
            ViewBag.Id = Key;
            ViewBag.NewUser= Uzer;
            
            return View("dashboard",Allinvites);
        }
//Wedding Creation page
       
        [HttpGet("NewWedding")]
        public IActionResult NewWedding()
        {
            return View("NewWedding");


        }
//Creatin a Wedding

        [HttpPost("createwed")]
        public IActionResult createwed(Wedding newOne)
        {

                dbContext.wedding.Add(newOne);
                dbContext.SaveChanges();
                return RedirectToAction("show",new {WeddingId = newOne.WeddingId });
            
        }


        [HttpPost("rsvp/{WeddingId}")]
        public IActionResult rsvp(int WeddingId)
        {
            Reservation rsvp = new Reservation
            {
                UserId = (int) HttpContext.Session.GetInt32("Id"),
                WeddingId = WeddingId

            };

                dbContext.reservation.Add(rsvp);
                dbContext.SaveChanges();
                return RedirectToAction("dashboard");
        }

        [HttpPost("unrsvp/{WeddingId}")]
        public IActionResult unrsvp(int WeddingId)
        {
            Reservation rsvp = dbContext.reservation.Where(a=>a.UserId==(int) HttpContext.Session.GetInt32("Id")).Where(b=>b.WeddingId==WeddingId)
            .SingleOrDefault();

                dbContext.reservation.Remove(rsvp);
                dbContext.SaveChanges();
                return RedirectToAction("dashboard");
        }



        [HttpGet("show/{WeddingId}")]
        public IActionResult show(int WeddingId)
        {
            Wedding RetrievedOne = dbContext.wedding
            .Include(a=>a.Users)
            .ThenInclude(b=>b.Auser)
            .FirstOrDefault(us => us.WeddingId == WeddingId);
            ViewBag.AllGuest= RetrievedOne;
            

                return View("Show",RetrievedOne);
        }


        
    }
}
