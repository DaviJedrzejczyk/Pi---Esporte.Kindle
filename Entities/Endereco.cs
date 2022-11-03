using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Endereco : Entity
    {
        public Endereco()
        {

        }

        public Endereco(string? rua, string? bairro, string? cEP, string? cidade, Estado estado, string complemento, string? numero, string pontoReferencia)
        {
            Rua = rua;
            Bairro = bairro;
            CEP = cEP;
            Cidade = cidade;
            Estado = estado;
            Complemento = complemento;
            Numero = numero;
            PontoReferencia = pontoReferencia;
        }

        public string? Rua { get; set; }
        public string? Bairro { get; set; }
        public string? CEP { get; set; }
        public string? Cidade { get; set; }
        public Estado Estado { get; set; }
        public int EstadoID { get; set; }
        public string Complemento { get; set; }
        public string? Numero { get; set; }
        public string PontoReferencia { get; set; }
     
    }
}
