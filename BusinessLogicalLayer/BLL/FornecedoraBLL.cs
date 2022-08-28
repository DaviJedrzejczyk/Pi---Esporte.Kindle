using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators.Fornecedoras;
using DataAccessLayer.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.VisualBasic;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class FornecedoraBLL : IFornecedoraService
    {
        private readonly IFornecedoraDALService fornecedoraDAL;
        public FornecedoraBLL(IFornecedoraDALService fornecedoraDALService)
        {
            fornecedoraDAL = fornecedoraDALService;
        }
        public async Task<Response> Insert(Fornecedor item)
        {
            FornecedoraInsertValidator validationRules = new();
            Response response = validationRules.Validate(item).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await fornecedoraDAL.Insert(item);
        }

        public async Task<Response> Update(Fornecedor item)
        {
            FornecedoraUpdateValidator validationRules = new();
            Response response = validationRules.Validate(item).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await fornecedoraDAL.Update(item);
        }
        public async Task<Response> Delete(Fornecedor item)
        {
            FornecedoraDeleteValidator validations = new();
            Response response = validations.Validate(item).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await fornecedoraDAL.Delete(item);
        }

        public async Task<DataResponse<Fornecedor>> GetAll()
        {
            return await fornecedoraDAL.GetAll();
        }

        public async Task<SingleResponse<Fornecedor>> GetById(Fornecedor fornecedor)
        {
            FornecedoraGetByIdValidator validationRules = new();
            SingleResponse<Fornecedor> singleResponse = validationRules.Validate(fornecedor).ToSingleResponse<Fornecedor>(fornecedor);
            if (!singleResponse.HasSuccess)
            {
                return singleResponse;
            }
            return await fornecedoraDAL.GetById(fornecedor);
        }

    
    }
}
