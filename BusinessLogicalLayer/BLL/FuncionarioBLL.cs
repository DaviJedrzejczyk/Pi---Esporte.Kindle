using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators.Enderecos;
using BusinessLogicalLayer.Validators.Funcionarios;
using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessLogicalLayer.BLL
{
    public class FuncionarioBLL : IFuncionarioService
    {

        private readonly IFuncionarioDALService funcionarioDAL;
        private readonly IEnderecoDALService endereco;
        public FuncionarioBLL(IFuncionarioDALService _funcionarioDAL, IEnderecoDALService enderecoDALService)
        {
            funcionarioDAL = _funcionarioDAL;
            endereco = enderecoDALService;
        }
        public async Task<Response> Insert(Funcionario funcionario)
        {
            FuncionarioInsertValidator insertValidator = new();
            Response response = insertValidator.Validate(funcionario).ToResponse();
            if (response.HasSuccess)
            {
                EnderecoInsertValidator validationRules = new();
                response = validationRules.Validate(funcionario.Endereco).ToResponse();
                if (response.HasSuccess)
                {
                    using TransactionScope scope = new();
                    response = await endereco.Insert(funcionario.Endereco);
                    response = await funcionarioDAL.Insert(funcionario);
                    if (!response.HasSuccess)
                        return response;

                    scope.Complete();
                }
                return response;
            }
            return response;
        }

        public async Task<Response> Update(Funcionario funcionario)
        {
            FuncionarioUpdateValidator updateValidator = new();
            Response response = updateValidator.Validate(funcionario).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await funcionarioDAL.Update(funcionario);
        }
        public async Task<Response> Delete(Funcionario funcionario)
        {
            FuncionarioDeleteValidator deleteValidator = new();
            Response response = deleteValidator.Validate(funcionario).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await funcionarioDAL.Delete(funcionario);
        }

        public async Task<DataResponse<Funcionario>> GetAll()
        {
            return await funcionarioDAL.GetAll();
        }

        public async Task<SingleResponse<Funcionario>> GetById(Funcionario funcionario)
        {

            return await funcionarioDAL.GetById(funcionario);
        }

        public async Task<SingleResponse<Funcionario>> GetLogin(Funcionario funcionario)
        {
            FuncionarioLoginValidator validations = new();
            SingleResponse<Funcionario> singleResponse = validations.Validate(funcionario).ToSingleResponse<Funcionario>(funcionario);
            if (!singleResponse.HasSuccess)
            {
                return singleResponse;
            }
            return await funcionarioDAL.GetLogin(funcionario);
        }
    }
}
