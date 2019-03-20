using System.ComponentModel.DataAnnotations;

namespace ES.Web.ViewModels.Identity
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}