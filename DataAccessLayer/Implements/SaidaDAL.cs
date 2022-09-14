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
    public class SaidaDAL : ISaidaDALService
    {
        private readonly PIKindleDB _kindle;
        public SaidaDAL(PIKindleDB kindle)
        {
            _kindle = kindle;
        }

        public async Task<Response> Insert(Saida saida)
        {
            _kindle.Add(saida);
            try
            {
                await _kindle.SaveChangesAsync();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
        }
        public async Task<DataResponse<SaidaView>> GetAll()
        {
            try
            {
                List<SaidaView> saidaViews = await _kindle.SaidaViews.ToListAsync();
                return DataResponseFactory<SaidaView>.CreateInstance().CreateSuccessResponse(saidaViews);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<SaidaView>.CreateInstance().CreateFailureResponse(ex);
            }
        }

        public async Task<SingleResponse<Saida>> GetById(Saida saida)
        {
            try
            {
                Saida? saida1 = await _kindle.Saidas.FindAsync(saida.ID);

                if (saida1 == null)
                    return SingleResponseFactory<Saida>.CreateInstance().CreateFailureSingleResponse();

                return SingleResponseFactory<Saida>.CreateInstance().CreateSuccessSingleResponse(saida1);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Saida>.CreateInstance().CreateFailureSingleResponse(ex);
            }
        }

        public async Task<SingleResponse<SaidaView>> GetSaidaViewById(Saida saida)
        {
            try
            {
                SaidaView? saida1 = await _kindle.SaidaViews.FindAsync(saida.ID);
                
                if (saida1 == null)
                    return SingleResponseFactory<SaidaView>.CreateInstance().CreateFailureSingleResponse();

                return SingleResponseFactory<SaidaView>.CreateInstance().CreateSuccessSingleResponse(saida1);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<SaidaView>.CreateInstance().CreateFailureSingleResponse(ex);
            }
        }

        public async Task<SingleResponse<List<SaidaView>>> GetByDate(FilterSaida saida)
        {
            try
            {
                List<SaidaView> saidaViews = await _kindle.SaidaViews.Where(s => s.DataSaida <= saida.Inicio &&
                                                                                 s.DataSaida <= saida.Fim).ToListAsync();
                return SingleResponseFactory<List<SaidaView>>.CreateInstance().CreateSuccessSingleResponse(saidaViews);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<List<SaidaView>>.CreateInstance().CreateFailureSingleResponse(ex);
            }
        }
    }
}
