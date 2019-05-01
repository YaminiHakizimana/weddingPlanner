using System;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Reservation
    {
        [Key]

        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public User Auser { get; set; }
        public int WeddingId { get; set; }
        public Wedding Awedding{get;set;}
        
       
    }
}