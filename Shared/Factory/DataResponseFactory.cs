using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Factory
{
    public class DataResponseFactory<T>
    {
        private static DataResponseFactory<T> _factory;
        public static DataResponseFactory<T> CreateInstance()
        {
            if (_factory == null)
            {
                _factory = new DataResponseFactory<T>();
            }
            return _factory;
        }
        public DataResponse<T> CreateSuccessResponse(List<T> Itens)
        {
            return new DataResponse<T>()
            {
                HasSuccess = true,
                Message = ResponsesConstants.MENSAGEM_SUCESSO,
                Itens = Itens,
            };
        }
        public DataResponse<T> CreateFailureResponse(Exception ex)
        {
            return new DataResponse<T>()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
                Exception = ex,
            };
        }
        public DataResponse<T> CreateFailureResponse()
        {
            return new DataResponse<T>()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
            };
        }
    }
}
