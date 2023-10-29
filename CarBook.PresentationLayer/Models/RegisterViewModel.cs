using System.ComponentModel.DataAnnotations;

namespace CarBook.PresentationLayer.Models
{
    public class RegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil, tekrar kontrol edin.")]
        public string ConfirmPassword { get; set; }
    }
}
