using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using Shared.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class VendaDAL : IVendaDALService
    { 
        private readonly PIKindleDB pIKindleDB;
        public VendaDAL(PIKindleDB pIKindleDB)
        {
            this.pIKindleDB = pIKindleDB;
        }

        public async Task<Response> Insert(Venda venda)
        {
            pIKindleDB.Add(venda);
            try
            {
                await pIKindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public async Task<DataResponse<Venda>> GetAll()
        {
            try
            {
                List<Venda>
            }
            catch (Exception ex)
            {

                throw;
            }
        }

       

      
    }
}
