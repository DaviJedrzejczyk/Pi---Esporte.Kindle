using Entities.Enums;

namespace WEBPresentationLayer.Models.Cliente
{
    public class ClienteUpdateViewModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Genero Genero { get; set; }
    }
}
