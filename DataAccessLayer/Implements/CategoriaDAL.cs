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
    public class CategoriaDAL : ICategoriaDALService
    {
        private readonly string _connection = ConnectionString._connectionString;
        public Task<Response> Insert(Categoria item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(Categoria item)
        {
            throw new NotImplementedException();
        }
        public Task<Response> Delete(Categoria item)
        {
            throw new NotImplementedException();
        }

        public Task<DataResponse<Categoria>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<Categoria>> GetById(int id)
        {
            throw new NotImplementedException();
        }

    
    }
}
