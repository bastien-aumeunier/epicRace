using App.Models;

namespace App.Models
{
    public class Pilote
    {
        public int Id {get; set;}
        public string? Name {get; set;}

        public string? FirstName {get; set;}

        public DateOnly Naissance {get; set;}

        public string? Mail {get; set;}

        public string? PassWord {get; set;}

        public List<Car> Cars {get; set;}

        public List<Race> Race {get; set;}
    }
}