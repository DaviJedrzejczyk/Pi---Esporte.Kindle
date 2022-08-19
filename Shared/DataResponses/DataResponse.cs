using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataResponses
{
    public class DataResponse<T> : Response
    {
        public List<T> Itens { get; set; }
    }
}
