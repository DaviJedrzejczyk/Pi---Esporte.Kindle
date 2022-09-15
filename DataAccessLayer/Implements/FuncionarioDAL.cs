using DataAccessLayer.Interfaces;
using Entities;
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
        
        public async Task<Response> Insert(Funcionario funcionario)
        {
            return null;
        }

        public async Task<Response> Update(Funcionario funcionario)
        {
            return null;
        }

        public async Task<Response> Delete(Funcionario funcionario)
        {
            return null;
        }

        public async Task<DataResponse<Funcionario>> GetAll()
        {
            return null;
        }

        public async Task<SingleResponse<Funcionario>> GetById(Funcionario funcionario)
        {
            return null;
        }

        public async Task<SingleResponse<Funcionario>> GetLogin(Funcionario funcionario)
        {
            return null;
        }

       
    }
}
