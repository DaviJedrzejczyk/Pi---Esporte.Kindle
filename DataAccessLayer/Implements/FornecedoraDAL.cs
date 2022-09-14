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
    public class FornecedoraDAL : IFornecedoraDALService
    {
        private readonly PIKindleDB _kindleDB;
        public FornecedoraDAL(PIKindleDB kindleDB)
        {
            _kindleDB = kindleDB;
        }

        public async Task<Response> Insert(Fornecedor fornecedor)
        {
            _kindleDB.Add(fornecedor);
            try
            {
                await _kindleDB.SaveChangesAsync();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
        }

        public async Task<Response> Update(Fornecedor fornecedor)
        {
            Fornecedor fornecedor1 = _kindleDB.Fornecedores.Find(fornecedor.ID);
            fornecedor1.Nome_Contato = fornecedor.Nome_Contato;
            fornecedor1.Telefone = fornecedor.Telefone;
            fornecedor1.Email = fornecedor.Email;
            fornecedor1.IsAtivo = fornecedor.IsAtivo;
            try
            {
                await _kindleDB.SaveChangesAsync();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
        }
        public async Task<Response> Delete(Fornecedor fornecedor)
        {
            Fornecedor fornecedor1 = _kindleDB.Fornecedores.Find(fornecedor.ID);
            _kindleDB.Remove(fornecedor1);
            try
            {
                await _kindleDB.SaveChangesAsync();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
        }

        public async Task<DataResponse<Fornecedor>> GetAll()
        {
            try
            {
                List<Fornecedor> fornecedors = await _kindleDB.Fornecedores.ToListAsync();
                return DataResponseFactory<Fornecedor>.CreateInstance().CreateSuccessResponse(fornecedors);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Fornecedor>.CreateInstance().CreateFailureResponse(ex);
            }
        }

        public async Task<SingleResponse<Fornecedor>> GetById(Fornecedor fornecedor)
        {
            try
            {
                Fornecedor? fornecedors = await _kindleDB.Fornecedores.FindAsync(fornecedor.ID);
                return SingleResponseFactory<Fornecedor>.CreateInstance().CreateSuccessSingleResponse(fornecedors);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Fornecedor>.CreateInstance().CreateFailureSingleResponse(ex);
            }
        }


    }
}

