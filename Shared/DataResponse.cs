using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class DataResponse<T> : Response
    {
        public List<T> Itens { get; set; }
        public DataResponse()
        {

        }
        public DataResponse(string Message, bool hasSuccess, List<T> values) : base(hasSuccess, Message)
        {
            Itens = values;
        }
    }
}
