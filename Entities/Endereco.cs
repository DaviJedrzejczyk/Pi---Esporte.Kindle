using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Endereco
    {
        public int ID { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public Estado Estado { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string PontoReferencia { get; set; }
        public Endereco()
        {

        }
        public Endereco(string rua, string bairro, string cep, string cidade, Estado estado, string numero, string complemento, string pontoReferencia)
        {
            this.Rua = rua;
            this.Bairro = bairro;
            this.CEP = cep;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Numero = numero;
            this.Complemento = complemento;
            this.PontoReferencia = pontoReferencia;
        }
    }
}
