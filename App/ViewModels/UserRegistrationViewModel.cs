using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class UserRegistrationViewModel
    {
        
    [Required(ErrorMessage = "Vous devez renseigner un prénom à votre compte")]
    public string? FirstName { get; set; }


    [Required(ErrorMessage = "Vous devez renseigner un nom à votre compte")]
    public string? LastName { get; set; }

    [Required(ErrorMessage = "Vous devez renseigner une date de naissance à votre compte")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateOnly Naissance { get; set; }


    [Required(ErrorMessage = "Mail obligatoire")]
    [EmailAddress(ErrorMessage = "Veuillez entrer une adresse mail valide")]
    public string? Email { get; set; }


    [Required(ErrorMessage = "Password obligatoire")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }


    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Les mots de passe ne correspondent pas")]
    public string? ConfirmPassword { get; set; }

    }
}