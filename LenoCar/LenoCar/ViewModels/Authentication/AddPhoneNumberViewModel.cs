using System.ComponentModel.DataAnnotations;

namespace LenoCar.ViewModels.Authentication
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}