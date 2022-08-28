using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators.Clientes;
using DataAccessLayer.Interfaces;
using Entities;
using Entities.Enums;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class ClienteBLL : IClienteService
    {
        private readonly IClienteDALService clienteDAL;
        public ClienteBLL(IClienteDALService clienteDAL)
        {
            this.clienteDAL = clienteDAL;
        }

        public Response Insert(Cliente cliente)
        {
            ClienteInsertValidator insertValidator = new();
            Response response = insertValidator.Validate(cliente).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return clienteDAL.Insert(cliente);
        }

        public Response Update(Cliente cliente)
        {
            ClienteUpdateValidator updateValidator = new();
            Response response = updateValidator.Validate(cliente).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return clienteDAL.Update(cliente);
        }
        public Response Delete(Cliente cliente)
        {
            return clienteDAL.Delete(cliente);
        }

        public DataResponse<Cliente> GetAll()
        {
            return clienteDAL.GetAll();
        }

        public SingleResponse<Cliente> GetById(int id)
        {
            return clienteDAL.GetById(id);
        }

    }
}
