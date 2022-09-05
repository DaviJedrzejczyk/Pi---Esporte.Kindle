using DataAccessLayer.Interfaces;
using Entities;
using Entities.Filters;
using Microsoft.EntityFrameworkCore;
using Shared;
using Shared.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class EntradaDAL : IEntradaDALService
    {
        private readonly PIKindleDB pIKindleDB;
        public EntradaDAL(PIKindleDB pIKindleDB)
        {
            this.pIKindleDB = pIKindleDB;
        }

        public async Task<Response> Insert(Entrada entrada)
        {
            pIKindleDB.Add(entrada);
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
        public async Task<DataResponse<EntradaView>> GetAll()
        {
            try
            {
                List<EntradaView> entradaViews = await pIKindleDB.EntradaViews.ToListAsync();
                return DataResponseFactory<EntradaView>.CreateSuccessResponse(entradaViews);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<EntradaView>.CreateFailureResponse(ex);
            }
        }
        public async Task<SingleResponse<EntradaView>> GetById(Entrada entrada)
        {
            try
            {
                EntradaView? entrada1 = await pIKindleDB.EntradaViews.FindAsync(entrada.ID);

                if (entrada1 == null)
                    return SingleResponseFactory<EntradaView>.CreateFailureSingleResponse();

                return SingleResponseFactory<EntradaView>.CreateSuccessSingleResponse(entrada1);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<EntradaView>.CreateFailureSingleResponse(ex);
            }
        }
        public async Task<SingleResponse<List<EntradaView>>> GetByDate(FilterEntrada filterEntrada)
        {
            try
            {
                List<EntradaView> entradaViews = await pIKindleDB.EntradaViews.Where(e => e.DataEntrada <= filterEntrada.Inicio &&
                                                                                          e.DataEntrada <= filterEntrada.Fim).ToListAsync();
                return SingleResponseFactory<List<EntradaView>>.CreateSuccessSingleResponse(entradaViews);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<List<EntradaView>>.CreateFailureSingleResponse(ex);
            }
        }
    }
}
