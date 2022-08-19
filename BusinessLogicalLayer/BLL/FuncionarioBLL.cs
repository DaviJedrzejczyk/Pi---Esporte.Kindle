using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validator.Funcionarios;
using DataAccessLayer.Interfaces;
using Entities;
using Shared.DataResponses;
using Shared.Responses;
using Shared.SingleResponses;
using System;
using System.Collections.Generic;
using System.Linq;
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
            InsertValidator insertValidator = new();
            Response response = insertValidator.Validate(funcionario).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return funcionarioDAL.Insert(funcionario);
        }

        public Response Update(Funcionario funcionario)
        {
            UpdateValidator updateValidator = new();
            Response response = updateValidator.Validate(funcionario).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return funcionarioDAL.Update(funcionario);
        }
        public Response Delete(Funcionario funcionario)
        {
            DeleteValidator deleteValidator = new();
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

 
    }
}
