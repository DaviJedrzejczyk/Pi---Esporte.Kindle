using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.SingleResponses;
using FluentValidation.Results;
namespace BusinessLogicalLayer.Extensions
{
    internal static class SingleResponseExtension
    {
        public static SingleResponse<T> ToSingleResponse<T>(this ValidationResult result)
        {
            StringBuilder sb = new();
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    sb.AppendLine(item.ErrorMessage);
                }
                return new SingleResponse<T>()
                {
                    HasSuccess = false,
                    Message = sb.ToString()
                };
            }
            return new SingleResponse<T>()
            {
                HasSuccess = true,
                Message = "Entidade validada com sucesso!",
            };
        }
    }
}
