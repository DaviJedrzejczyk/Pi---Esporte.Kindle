using DataAccessLayer.Interfaces;
using Entities;
using Shared.Factory;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;

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
            Cliente cliente1 = _kindleDB.Clientes.Find(cliente.ID);
            cliente1.Nome = cliente.Nome;
            cliente1.Sobrenome = cliente.Sobrenome;
            cliente1.Telefone = cliente.Telefone;
            cliente1.Email = cliente.Email;
            cliente1.Genero = cliente.Genero;
            
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
            Cliente cliente1 = _kindleDB.Clientes.Find(cliente.ID);
            _kindleDB.Clientes.Remove(cliente1);
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
                List<Cliente> clientes = _kindleDB.Clientes.ToList();
                return DataResponseFactory<Cliente>.CreateSuccessResponse(clientes);
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
