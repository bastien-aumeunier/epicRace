using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class CarsType
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Color { get; set; }

        public List<CarsType> CarTypes { get; set; }

    }
}