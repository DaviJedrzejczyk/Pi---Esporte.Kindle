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

        public Task<Response> Insert(Categoria item)
        {
           return categoriaDALService.Insert(item);
        }

        public Task<Response> Update(Categoria item)
        {
            return categoriaDALService.Update(item);
        }
        public Task<Response> Delete(Categoria item)
        {
            return categoriaDALService.Delete(item);
        }

        public Task<DataResponse<Categoria>> GetAll()
        {
            return categoriaDALService.GetAll();
        }

        public Task<SingleResponse<Categoria>> GetById(int id)
        {
            return categoriaDALService.GetById(id);
        }

       
    }
}
