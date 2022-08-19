using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validator.Clientes;
using DataAccessLayer.Interfaces;
using Entities;
using Shared.DataResponses;
using Shared.Responses;
using Shared.SingleResponses;

namespace BusinessLogicalLayer.BLL
{
    public class ClienteBLL : IClienteService
    {
        private readonly IClienteDALService clienteDAL;
        public ClienteBLL(IClienteDALService _clienteDAL)
        {
            clienteDAL = _clienteDAL;
        }
        public Response Insert(Cliente cliente)
        {
            InsertValidator insertValidator = new();
            Response response = insertValidator.Validate(cliente).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return clienteDAL.Insert(cliente);
        }

        public Response Update(Cliente cliente)
        {
            UpdateValidator updateValidator = new();
            Response response = updateValidator.Validate(cliente).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return clienteDAL.Update(cliente);
        }
        public Response Delete(Cliente cliente)
        {
            DeleteValidator deleteValidator = new();
            Response response = deleteValidator.Validate(cliente).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
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
