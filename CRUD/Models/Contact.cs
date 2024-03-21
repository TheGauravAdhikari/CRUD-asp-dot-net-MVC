using Microsoft.AspNetCore.Mvc;

namespace CRUD.Models
{
    public class Contact 
    {
        public int Id { get; set; }
        public required string name { get; set; }

        public required string address { get; set; } 

        public required string phone { get; set; } 

        public required string email { get; set; } 
    }
}
