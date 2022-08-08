using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı adı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string Password { get; set; }

    }
}
