using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Factory
{
    public class ResponseFactory
    {
        public static Response CreateSuccessResponse()
        {
            return new Response()
            {
                HasSuccess = true,
                Message = ResponsesConstants.MENSAGEM_SUCESSO,
            };
        }
        public static Response CreateFailureResponse(Exception ex)
        {
            return new Response()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
                Exception = ex,
            };
        }
        public static Response CreateFailureResponse()
        {
            return new Response()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,

            };
        }
    }
}
