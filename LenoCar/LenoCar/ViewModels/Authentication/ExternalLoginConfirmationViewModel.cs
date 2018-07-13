using System.ComponentModel.DataAnnotations;

namespace LenoCar.ViewModels.Authentication
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}