using System.ComponentModel.DataAnnotations;
using Xunit;

namespace Demo.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage="Lütfen isim değeri giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim değeri giriniz")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı adı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        [Compare("Password", ErrorMessage="Lütfen şifrenin eşleştiğine emin ol")]
        public string ConfirmPassword { get; set; }




    }
}
