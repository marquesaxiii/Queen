using System;
using Queen.Shared.Entity.Enums;

namespace Queen.Shared.Entity.Models
{
    public class ClientModel 
    {
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}