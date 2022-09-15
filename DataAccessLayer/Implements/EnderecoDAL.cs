using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class EnderecoDAL : IEnderecoDALService
    {
        public Task<Response> Insert(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(Endereco endereco)
        {
            throw new NotImplementedException();
        }
        public Task<Response> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DataResponse<Endereco>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<Endereco>> GetById(int id)
        {
            throw new NotImplementedException();
        }

      
    }
}
