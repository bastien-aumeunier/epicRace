using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateRaceRequest
    {
        [Required(ErrorMessage = "Vous devez renseigner un nom à votre course")]
        [MaxLength(10)]
        public string? RaceName { get; set; }

        [Required(ErrorMessage = "Vous devez renseigner une date à votre course")]
        [DataType(DataType.DateTime)]
        public DateTime RaceDate { get; set; }

        [Required(ErrorMessage = "La course doit avoir minimum 2 places")]
        [Range(2, 20)]
        public int NumberOfPlaces { get; set; }
        
        [Required(ErrorMessage = "L'age minimum est de 16 ans")]
        [Range(16, 100)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Vous devez renseigner une latitude à votre course")]
        public string? Latitude { get; set; }

        [Required(ErrorMessage = "Vous devez renseigner une longitude à votre course")]
        public string? Longitude { get; set; }
    }
}