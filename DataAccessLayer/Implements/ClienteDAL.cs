using DataAccessLayer.Interfaces;
using Entities;
using Shared.Factory;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class ClienteDAL : IClienteDALService
    {
        private readonly PIKindleDB _kindleDB;
        public ClienteDAL(PIKindleDB kindleDB)
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
                return DataResponseFactory<Cliente>.CreateSuccessResponse(_kindleDB.Clientes.ToList());
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Cliente>.CreateFailureResponse(ex);
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
