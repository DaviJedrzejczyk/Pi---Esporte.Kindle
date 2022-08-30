using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators.Enderecos;
using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class EnderecoBLL : IEnderecoService
    {
        private readonly IEnderecoDALService enderecoDAL;
        public EnderecoBLL(IEnderecoDALService enderecoDAL)
        {
            this.enderecoDAL = enderecoDAL;
        }
        public async Task<Response> Insert(Endereco endereco)
        {
            EnderecoInsertValidator validationRules = new();
            Response response = validationRules.Validate(endereco).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await enderecoDAL.Insert(endereco);
        }

        public Task<Response> Update(Endereco endereco)
        {
            EnderecoUpdateValidator validationRules = new();
            Response response = validationRules.Validate(endereco).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return enderecoDAL.Update(endereco);
        }
        public async Task<Response> Delete(Endereco endereco)
        {
            EnderecoDeleteValidator validationRules = new();
            Response response = validationRules.Validate(endereco).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await enderecoDAL.Delete(endereco);
        }

        public async Task<DataResponse<Endereco>> GetAll()
        {
            return await enderecoDAL.GetAll();
        }

        public async Task<SingleResponse<Endereco>> GetById(Endereco endereco)
        {
            return await enderecoDAL.GetById(endereco);
        }

     
    }
}
