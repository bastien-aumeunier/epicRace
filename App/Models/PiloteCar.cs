namespace App.Models
{
    public class PiloteCar
    {
        public int Id { get; set; }

        public int PiloteId { get; set; }
        public Pilote? Pilote { get; set; }

        public int CarId { get; set; }
        public Car? Cars { get; set; }
    }
}