using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class SingleResponse<T> : Response
    {
        public T Item { get; set; }
        public SingleResponse()
        {

        }

        public SingleResponse(bool hasSuccess,string message,T item) : base(hasSuccess, message)
        {
            Item = item;
        }
    }
}
