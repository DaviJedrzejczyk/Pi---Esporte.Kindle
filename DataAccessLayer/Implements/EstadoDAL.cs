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
    public class EstadoDAL : IEstadoDALService
    {
		private readonly PIKindleDB _kindleDB;
		public EstadoDAL(PIKindleDB pIKindleDB)
		{
			_kindleDB = pIKindleDB;
		}
        public DataResponse<Estado> GetAll()
        {
			try
			{
				List<Estado> estados = _kindleDB.Estados.ToList();
				return DataResponseFactory<Estado>.CreateSuccessResponse(estados);
			}
			catch (Exception ex)
			{
				return DataResponseFactory<Estado>.CreateFailureResponse(ex);
			}
        }
    }
}
