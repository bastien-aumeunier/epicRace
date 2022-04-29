using Microsoft.AspNetCore.Identity;
using App.Models;
using System.Security;

namespace App.Models
{
    public class Pilote : IdentityUser
    {
        public string? Name { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateOnly Naissance { get; set; }

        public List<Car> Cars { get; set; }

        public List<Race> Race { get; set; }
    }
}