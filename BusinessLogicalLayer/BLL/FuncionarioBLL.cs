using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
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

namespace BusinessLogicalLayer.BLL
{
    public class FuncionarioBLL : IFuncionarioService
    {
        private readonly IFuncionarioDALService funcionarioDAL;
        public FuncionarioBLL(IFuncionarioDALService _funcionarioDAL)
        {
            funcionarioDAL = _funcionarioDAL;
        }
        public Response Insert(Funcionario funcionario)
        {
            FuncionarioInsertValidator insertValidator = new();
            Response response = insertValidator.Validate(funcionario).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return funcionarioDAL.Insert(funcionario);
        }

        public Response Update(Funcionario funcionario)
        {
            FuncionarioUpdateValidator updateValidator = new();
            Response response = updateValidator.Validate(funcionario).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return funcionarioDAL.Update(funcionario);
        }
        public Response Delete(Funcionario funcionario)
        {
            FuncionarioDeleteValidator deleteValidator = new();
            Response response = deleteValidator.Validate(funcionario).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return funcionarioDAL.Delete(funcionario);
        }

        public DataResponse<Funcionario> GetAll()
        {
            return funcionarioDAL.GetAll();
        }

        public SingleResponse<Funcionario> GetById(int id)
        {

            return funcionarioDAL.GetById(id);
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
