using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameFinder.Models
{
    public class UserAccount
    {
        public int Id { get; set; }

        [Required]
        [MinLength(7)]
        public string Username { get; set; }

        [Required]
        [MinLength(7)]
        public string Password { get; set; }
        public datetime AccountCreated { get; set; }
    }
}