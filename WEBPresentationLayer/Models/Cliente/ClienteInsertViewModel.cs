
using Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace WEBPresentationLayer.Models.Cliente
{
    public class ClienteInsertViewModel
    {
        [Required(ErrorMessage = "Nome deve ser informado")]
        [StringLength(50, ErrorMessage = "Nome deve conter no máximo 50 caracteres", MinimumLength = 3, ErrorMessageResourceName = "Nome deve conter no minimo 3 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Email deve ser informado")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Cpf deve ser informado")]
        [StringLength(14, ErrorMessage = "Cpf deve conter no máximo 11 digitos", MinimumLength = 11, ErrorMessageResourceName = "Cpf deve conter no minimo 11")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Data de nascimento deve ser fornecida")]
        [DataType(DataType.DateTime, ErrorMessage = "Data deve ser inserida no formato correto")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Telefone deve ser inserido")]
        [StringLength(14, ErrorMessage = "Deve conter no maximo 11 digitos", MinimumLength = 9, ErrorMessageResourceName = "Deve conter no minimo 9 digitos")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Rg deve ser informado")]
        [StringLength(11, ErrorMessage = "Rg Deve conter 11 digitos", MinimumLength = 11, ErrorMessageResourceName = "Rg deve conter 11 digitos")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "Genero deve ser informado")]
        public Genero Genero { get; set; }
    }
}
