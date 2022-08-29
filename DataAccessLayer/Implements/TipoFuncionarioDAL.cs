using DataAccessLayer.Interfaces;
using Entities;
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
    public class TipoFuncionarioDAL : ITipoFuncionarioDALService
    {
        private readonly PIKindleDB _kindleDB;
        public TipoFuncionarioDAL(PIKindleDB pIKindleDB)
        {
            _kindleDB = pIKindleDB;
        }
        public async Task<DataResponse<TipoFuncionario>> GetAllTipos()
        {
			try
			{
                List<TipoFuncionario> tipoFuncionarios = await _kindleDB.TipoFuncionarios.ToListAsync();
                return DataResponseFactory<TipoFuncionario>.CreateSuccessResponse(tipoFuncionarios);
			}
			catch (Exception ex)
			{
                return DataResponseFactory<TipoFuncionario>.CreateFailureResponse(ex);
			}
        }
    }
}
