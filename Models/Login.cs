using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WeddingPlanner.Models;
    
public class LoginPage
{
    

    public string Email {get;set;}
    [Required]
    public string Password {get;set;}

   
} 