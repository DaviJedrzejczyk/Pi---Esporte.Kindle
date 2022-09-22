using BusinessLogicalLayer.Interfaces;
using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BLL
{
    public class EstadoBLL : IEstadoService
    {
        private readonly IEstadoDALService estadoDALService;
        public EstadoBLL(IEstadoDALService estadoDALService)
        {
            this.estadoDALService = estadoDALService;
        }

        public DataResponse<Estado> GetAll()
        {
            return estadoDALService.GetAll();
        }

        public async Task<SingleResponse<Estado>> GetById(int id)
        {
            return await estadoDALService.GetById(id);
        }
    }
}
