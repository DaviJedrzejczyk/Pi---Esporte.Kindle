using Entities.Enums;

namespace WEBPresentationLayer.Models.Cliente
{
    public class ClienteSelectViewModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Idade { get; set; }
        public Genero Genero { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
