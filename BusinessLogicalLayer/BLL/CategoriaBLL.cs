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
    public class CategoriaBLL : ICategoriaService
    {
        private readonly ICategoriaDALService categoriaDALService;
        public CategoriaBLL(ICategoriaDALService categoriaDALService)
        {
            this.categoriaDALService = categoriaDALService;
        }

        public Response Insert(Categoria item)
        {
           return categoriaDALService.Insert(item);
        }

        public Response Update(Categoria item)
        {
            return categoriaDALService.Update(item);
        }
        public Response Delete(Categoria item)
        {
            return categoriaDALService.Delete(item);
        }

        public DataResponse<Categoria> GetAll()
        {
            return categoriaDALService.GetAll();
        }

        public SingleResponse<Categoria> GetById(int id)
        {
            return categoriaDALService.GetById(id);
        }

       
    }
}
