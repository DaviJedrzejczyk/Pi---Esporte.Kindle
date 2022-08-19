using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Estado
    {
        public int Id { get; set; }
        public string Unidade_Federal { get; set; }
        public Estado()
        {

        }
        public Estado(int id, string unidade_Federal)
        {
            Id = id;
            Unidade_Federal = unidade_Federal;
        }
    }
}
