using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Litfen isim değeri giriniz ")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Litfen soyisim değeri giriniz ")]
        public string? SureName { get; set; }

        [Required(ErrorMessage = "Litfen kullanıcı adı değeri giriniz ")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Litfen Mail Giriniz değeri giriniz ")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Litfen Şifre Giriniz değeri giriniz ")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Litfen Şifreyi tekarar değeri giriniz ")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olun")]
        public string? ConfirmPassword { get; set; }
    }
}
