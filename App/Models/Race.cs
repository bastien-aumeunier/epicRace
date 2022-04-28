
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime EventDate { get; set; }

        public int Places {get; set;}

        public int Age {get; set;}

        public string? Latitude {get; set;}

        public string? Longitude {get; set;}
    }
}