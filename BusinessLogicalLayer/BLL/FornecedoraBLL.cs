using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators.Fornecedoras;
using DataAccessLayer.Interfaces;
using Entities;
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
        public async Task<Response> Delete(int id)
        {
            if(id < 1)
            {
                return new Response(false, "Id não pode ser Null");
            }
            return await fornecedoraDAL.Delete(id);
        }

        public  DataResponse<Fornecedor> GetAll()
        {
            return fornecedoraDAL.GetAll();
        }

        public async Task<SingleResponse<Fornecedor>> GetById(int fornecedor)
        {
            if(fornecedor < 1)
            {
                return new SingleResponse<Fornecedor>(false, "Id não pode ser null", null);
            }
            return await fornecedoraDAL.GetById(fornecedor);
        }

    
    }
}
