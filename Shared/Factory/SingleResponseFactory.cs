using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Factory
{
    public class SingleResponseFactory<T>
    {
        public static SingleResponse<T> CreateSuccessSingleResponse(T item)
        {
            return new SingleResponse<T>()
            {
                HasSuccess = true,
                Message = ResponsesConstants.MENSAGEM_SUCESSO,
                Item = item
            };
        }
        public static SingleResponse<T> CreateFailureSingleResponse(Exception ex)
        {
            return new SingleResponse<T>()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
                Exception = ex,
            };
        }
        public static SingleResponse<T> CreateFailureSingleResponse()
        {
            return new SingleResponse<T>()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
            };
        }
    }
}
