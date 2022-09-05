using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Factory
{
    public class DataResponseFactory<T>
    {
        public static DataResponse<T> CreateSuccessResponse(List<T> Itens)
        {
            return new DataResponse<T>()
            {
                HasSuccess = true,
                Message = ResponsesConstants.MENSAGEM_SUCESSO,
                Itens = Itens,
            };
        }
        public static DataResponse<T> CreateFailureResponse(Exception ex)
        {
            return new DataResponse<T>()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
                Exception = ex,
            };
        }
        public static DataResponse<T> CreateFailureResponse()
        {
            return new DataResponse<T>()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
            };
        }
    }
}
