using BusinessLogicalLayer.Interfaces;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class VendaBLL : IVendaService
    {
        public Task<Response> Insert(Venda venda)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(Venda venda)
        {
            throw new NotImplementedException();
        }
        public Task<Response> Delete(Venda venda)
        {
            throw new NotImplementedException();
        }

        public Task<DataResponse<Venda>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<Venda>> GetById(Venda venda)
        {
            throw new NotImplementedException();
        }

      
    }
}
