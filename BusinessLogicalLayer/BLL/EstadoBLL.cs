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
        private readonly IEstadoDALService estadoDAL;
        public EstadoBLL(IEstadoDALService estadoDAL)
        {
            this.estadoDAL = estadoDAL;
        }
       

        public  DataResponse<Estado> GetAll()
        {
            return estadoDAL.GetAll();
        }
    }
}
