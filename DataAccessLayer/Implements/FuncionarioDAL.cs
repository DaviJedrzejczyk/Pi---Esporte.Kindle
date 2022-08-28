using DataAccessLayer.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using Shared;
using Shared.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class FuncionarioDAL : IFuncionarioDALService
    {
        private readonly PIKindleDB pIKindleDB;
        public FuncionarioDAL(PIKindleDB pI)
        {
            pIKindleDB = pI;
        }
        public Response Insert(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Response Update(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
        public Response Delete(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Funcionario> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Funcionario> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<SingleResponse<Funcionario>> GetLogin(Funcionario funcionario)
        {
            try
            {
                Funcionario login = await pIKindleDB.Funcionarios.Where(f => f.Email == f.Email).FirstOrDefaultAsync();
                if(login == null)
                {
                    return SingleResponseFactory<Funcionario>.CreateFailureSingleResponse();
                }
                return SingleResponseFactory<Funcionario>.CreateSuccessSingleResponse(login);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Funcionario>.CreateFailureSingleResponse(ex);
            }
        }
    }
}
