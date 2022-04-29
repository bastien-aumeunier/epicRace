namespace App.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int CarsType { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Marque { get; set; }
        public string? Model { get; set; }
        public int Power { get; set; }
    }
}