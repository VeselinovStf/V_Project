using System.ComponentModel.DataAnnotations;

namespace FMS.Web.ViewModels.Identity
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}