using System.ComponentModel.DataAnnotations;

namespace WEBPresentationLayer.Models.Login
{
    public class LoginViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Email deve ser informado")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Email deve conter entre 10 a 100 caracteres")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Senha deve ser informada")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Senha deve conter entre 6 a 20 caracteres")]
        public string Senha { get; set; }
    }
}
