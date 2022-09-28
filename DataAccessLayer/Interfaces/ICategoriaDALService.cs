using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Interfaces
{
    public interface ICategoriaDALService
    {
        Response Insert(Categoria categoria);
        Response Update(Categoria categoria);
        Response Delete(Categoria categoria);
        DataResponse<Categoria> GetAll();
        SingleResponse<Categoria> GetById(int id);
    }
}
