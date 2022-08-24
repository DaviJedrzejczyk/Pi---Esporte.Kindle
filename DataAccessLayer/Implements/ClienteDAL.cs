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
            _kindleDB.Clientes.Add(cliente);
            try
            {
                _kindleDB.SaveChanges();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public Response Update(Cliente cliente)
        {
            _kindleDB.Clientes.Update(cliente);
            try
            {
                _kindleDB.SaveChanges();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }
        public Response Delete(Cliente cliente)
        {
            _kindleDB.Clientes.Remove(cliente);
            try
            {
                _kindleDB.SaveChanges();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public DataResponse<Cliente> GetAll()
        {
            try
            {
                return DataResponseFactory<Cliente>.CreateSuccessDataResponse(_kindleDB.Clientes.ToList());
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Cliente>.CreateFailureDataResponse(ex);
            }
        }

        public SingleResponse<Cliente> GetById(int id)
        {
            try
            {
                Cliente single = _kindleDB.Clientes.Find(id);
                return SingleResponseFactory<Cliente>.CreateSuccessSingleResponse(single);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Cliente>.CreateFailureSingleResponse(ex);
            }
        }

    
    }
}
