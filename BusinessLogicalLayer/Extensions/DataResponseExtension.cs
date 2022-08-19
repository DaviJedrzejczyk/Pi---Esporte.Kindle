using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataResponses;
using FluentValidation.Results;
namespace BusinessLogicalLayer.Extensions
{
    internal static class DataResponseExtension
    {
        public static DataResponse<T> ToDataResponse<T>(this ValidationResult result)
        {
            StringBuilder sb = new();
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    sb.AppendLine(item.ErrorMessage);
                }
                return new DataResponse<T>()
                {
                    HasSuccess = false,
                    Message = sb.ToString()
                };
            }
            return new DataResponse<T>()
            {
                HasSuccess = true,
                Message = "Entidade validada com sucesso"
            };
        }
    }
}
