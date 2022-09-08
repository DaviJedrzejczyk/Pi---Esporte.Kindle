
using BusinessLogicalLayer.Extensions;
using BusinessLogicalLayer.Interfaces;
using BusinessLogicalLayer.Validators.Categorias;
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
        private readonly ICategoriaDALService categoriaDAL;
        public CategoriaBLL(ICategoriaDALService categoriaDAL)
        {
            this.categoriaDAL = categoriaDAL;
        }
        public async Task<Response> Insert(Categoria categoria)
        {
            CategoriaInsertValidator validationRules = new();
            Response response = validationRules.Validate(categoria).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await categoriaDAL.Insert(categoria);
        }

        public async Task<Response> Update(Categoria categoria)
        {
            CategoriaUpdateValidator validationRules = new();
            Response response = validationRules.Validate(categoria).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await categoriaDAL.Update(categoria);
        }
        public async Task<Response> Delete(Categoria categoria)
        {
            CategoriaDeleteValidator validationRules = new();
            Response response = validationRules.Validate(categoria).ToResponse();
            if (!response.HasSuccess)
            {
                return response;
            }
            return await categoriaDAL.Delete(categoria);
        }

        public async Task<DataResponse<Categoria>> GetAll()
        {
            return await categoriaDAL.GetAll();
        }

        public async Task<SingleResponse<Categoria>> GetById(Categoria categoria)
        {
            CategoriaGetByIdValidator validationRules = new();
            SingleResponse<Categoria> response = validationRules.Validate(categoria).ToSingleResponse<Categoria>(categoria);
            if (!response.HasSuccess)
            {
                return response;
            }
            return await categoriaDAL.GetById(categoria);
        }

        
    }
}
