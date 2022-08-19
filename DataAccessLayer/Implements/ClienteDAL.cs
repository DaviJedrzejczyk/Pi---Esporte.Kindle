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
    public class ClienteDAL : IClienteDALService
    {
        private readonly KindleDB _kindleDB;
        public ClienteDAL(KindleDB kindleDB)
        {
            _kindleDB = kindleDB;
        }
        public Response Insert(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Response Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
        public Response Delete(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Cliente> GetById(int id)
        {
            throw new NotImplementedException();
        }

    
    }
}
