using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PessoaFisica : Entity
    {
        public string CPF { get; set; }
        public string RG { get; set; }
        public PessoaFisica(string cpf, string rg)
        {
            CPF = cpf;
            RG = rg;
        }
        public PessoaFisica()
        {

        }
    }
}
