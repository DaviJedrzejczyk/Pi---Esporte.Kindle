using FluentValidation.Results;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Extensions
{
    internal static class SingleResponseExtension
    {
        public static SingleResponse<T> ToSingleResponse<T>(this ValidationResult result,T item)
        {
            StringBuilder sb = new();
            if (!result.IsValid)
            {
                foreach (var iten in result.Errors)
                {
                    sb.AppendLine(iten.ErrorMessage);
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
                Item = item
            };
        }

    }
}
