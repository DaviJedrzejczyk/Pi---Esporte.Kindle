using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Factory
{
    public class ResponseFactory
    {
        private static ResponseFactory _factory;
        public static ResponseFactory CreateInstance()
        {
            if (_factory == null)
            {
                _factory = new ResponseFactory();
            }
            return _factory;
        }
        public Response CreateSuccessResponse()
        {
            return new Response()
            {
                HasSuccess = true,
                Message = ResponsesConstants.MENSAGEM_SUCESSO,
            };
        }
        public Response CreateFailureResponse(Exception ex)
        {
            return new Response()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,
                Exception = ex,
            };
        }
        public Response CreateFailureResponse()
        {
            return new Response()
            {
                HasSuccess = false,
                Message = ResponsesConstants.MENSAGEM_FALHA,

            };
        }
        public Response CreateFailureResponse(string message)
        {
            return new Response()
            {
                HasSuccess = false,
                Message = message,

            };
        }
    }
}
