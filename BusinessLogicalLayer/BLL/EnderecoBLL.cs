using BusinessLogicalLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class EnderecoBLL : IEnderecoService
    {
        private readonly IEnderecoDALService enderecoDALService;
        public EnderecoBLL(IEnderecoDALService enderecoDALService)
        {
            this.enderecoDALService = enderecoDALService;
        }

        public async Task<Response> Delete(int id)
        {
            return await enderecoDALService.Delete(id);
        }

        public async Task<DataResponse<Endereco>> GetAll()
        {
            return await enderecoDALService.GetAll();
        }

        public async Task<SingleResponse<Endereco>> GetById(int id)
        {
            return await enderecoDALService.GetById(id);
        }
    }
}
