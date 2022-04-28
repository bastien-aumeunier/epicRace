namespace App.Models
{
    public class Car
    {
        public int Id { get; set; }
        public List<CarsType> CarsType { get; set; }
        public int CreationYear { get; set; }
        public string? Marque { get; set; }
        public string? Model { get; set; }
        public int Power { get; set; }
    }
}