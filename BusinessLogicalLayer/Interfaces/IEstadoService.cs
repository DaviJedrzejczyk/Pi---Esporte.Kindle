using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IEstadoService
    {
        Task<DataResponse<Estado>> GetAll();
        Task<SingleResponse<Estado>> GetById(int id);
    }
}
