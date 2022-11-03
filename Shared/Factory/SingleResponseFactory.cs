using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Factory
{
    public class SingleResponseFactory<T>
    {
        private static SingleResponseFactory<T> _factory;
        public static SingleResponseFactory<T> CreateInstance()
        {
            if (_factory == null)
            {
                _factory = new SingleResponseFactory<T>();
            }
            return _factory;
        }
        public SingleResponse<T> CreateSuccessSingleResponse(T item)
        {
            return new SingleResponse<T>()
            {
                HasSuccess = true,
                Message = ResponsesConstants.MENSAGEM_SUCESSO,
                Item = item
            };
        }
        public SingleResponse<T> CreateFailureSingleResponse(Exception ex)
        {
            return new SingleResponse<T>()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
                Exception = ex,
            };
        }
        public SingleResponse<T> CreateFailureSingleResponse(string message)
        {
            return new SingleResponse<T>()
            {
                HasSuccess = false,
                Message = message
            };
        }
        public SingleResponse<T> CreateFailureSingleResponse()
        {
            return new SingleResponse<T>()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
            };
        }
    }
}
