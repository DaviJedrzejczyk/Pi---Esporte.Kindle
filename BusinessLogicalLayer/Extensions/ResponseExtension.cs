﻿using FluentValidation.Results;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Extensions
{
    internal static class ResponseExtension
    {
        public static Response ToResponse(this ValidationResult result)
        {
            StringBuilder sb = new();
            if (!result.IsValid)
            {
                foreach (var item in result.Errors)
                {
                    sb.AppendLine(item.ErrorMessage);
                }
                return new Response()
                {
                    HasSuccess = false,
                    Message = sb.ToString(),
                };
            }
            return new Response()
            {
                HasSuccess = true,
                Message = "Entidade validada com sucesso!",
            };
        }
    }
}
