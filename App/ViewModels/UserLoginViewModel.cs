using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class UserLoginViewModel
    {
    [Required (ErrorMessage = "Vous devez renseigner votre Mail")]
    [EmailAddress]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Vous devez renseigner votre mot de passe")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Display(Name = "Remember me?")]
    public bool RememberMe { get; set; }
    }
}