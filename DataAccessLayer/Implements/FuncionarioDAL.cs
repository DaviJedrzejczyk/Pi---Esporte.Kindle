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

namespace DataAccessLayer.Implements
{
    public class FuncionarioDAL : IFuncionarioDALService
    {
        private readonly KindleDB _kindleDB;
        public FuncionarioDAL(KindleDB kindleDB)
        {
            _kindleDB = kindleDB;
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

      
    }
}
