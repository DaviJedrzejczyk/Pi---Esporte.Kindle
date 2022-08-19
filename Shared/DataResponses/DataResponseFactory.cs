using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataResponses
{
    public class DataResponseFactory<T>
    {
        public static DataResponse<T> CreateSuccessResponse(List<T> itens)
        {
            return new DataResponse<T>()
            {
                HasSuccess = true,
                Message = ResponsesConstants.MENSAGEM_SUCESSO,
                Itens = itens
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
    }
}
