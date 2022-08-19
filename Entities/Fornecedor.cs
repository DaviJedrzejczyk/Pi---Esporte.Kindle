using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Fornecedor
    {
        public int ID { get; set; }
        public string Cnpj { get; set; }
        public string Nome_Contato { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool IsAtivo { get; set; }
    }
}
