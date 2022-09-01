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
    public class CategoriaDAL : ICategoriaDALService
    {
        private readonly PIKindleDB _kindleDB;
        public CategoriaDAL(PIKindleDB kindleDB)
        {
            _kindleDB = kindleDB;
        }

        public async Task<Response> Insert(Categoria categoria)
        {
            _kindleDB.Add(categoria);
            try
            {
                await _kindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public async Task<Response> Update(Categoria categoria)
        {
            Categoria? categoria1 = _kindleDB.Categorias.Find(categoria.Id);
            if(categoria1 == null)
            {
                return ResponseFactory.CreateFailureResponse();
            }
            categoria1.Nome = categoria.Nome;
            categoria1.Descricao = categoria.Descricao;
            try
            {
                await _kindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }
        public async Task<Response> Delete(Categoria categoria)
        {
            Categoria? categoria1 = _kindleDB.Categorias.Find(categoria.Id);
            if (categoria1 == null)
            {
                return ResponseFactory.CreateFailureResponse();
            }
            _kindleDB.RemoveRange(categoria1);
            try
            {
                await _kindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public async Task<DataResponse<Categoria>> GetAll()
        {
            try
            {
                List<Categoria> categorias = await _kindleDB.Categorias.ToListAsync();
                return DataResponseFactory<Categoria>.CreateSuccessResponse(categorias);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Categoria>.CreateFailureResponse(ex);
            }
        }

        public async Task<SingleResponse<Categoria>> GetById(Categoria categoria)
        {
            
            try
            {
                Categoria? categoria1 = await _kindleDB.Categorias.FindAsync(categoria.Id);
                if (categoria1 == null)
                {
                    return SingleResponseFactory<Categoria>.CreateFailureSingleResponse();
                }
                return SingleResponseFactory<Categoria>.CreateSuccessSingleResponse(categoria1);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Categoria>.CreateFailureSingleResponse(ex);
            }
        }


    }
}
