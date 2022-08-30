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
    public class EnderecoDAL : IEnderecoDALService
    {
        private readonly PIKindleDB _kindleDB;
        public EnderecoDAL(PIKindleDB kindleDB)
        {
            _kindleDB = kindleDB;
        }

        public async Task<Response> Insert(Endereco endereco)
        {
            _kindleDB.Enderecos.Add(endereco);
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

        public async Task<Response> Update(Endereco endereco)
        {
            Endereco endereco1 = _kindleDB.Enderecos.Find(endereco.ID);
            endereco1.Numero = endereco.Numero;
            endereco1.CEP = endereco.CEP;
            endereco1.Rua = endereco.Rua;
            endereco1.Bairro = endereco.Bairro;
            endereco1.Cidade = endereco.Cidade;
            endereco1.Complemento = endereco.Complemento;
            endereco1.PontoReferencia = endereco.PontoReferencia;
            endereco1.Estado = endereco.Estado;
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
        public async Task<Response> Delete(Endereco endereco)
        {
            Endereco endereco1 = _kindleDB.Enderecos.Find(endereco.ID);
            _kindleDB.Enderecos.Remove(endereco1);
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

        public async Task<DataResponse<Endereco>> GetAll()
        {
            try
            {
                List<Endereco> enderecos = await _kindleDB.Enderecos.ToListAsync();
                return DataResponseFactory<Endereco>.CreateSuccessResponse(enderecos);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Endereco>.CreateFailureResponse(ex);
            }
        }

        public async Task<SingleResponse<Endereco>> GetById(Endereco endereco)
        {
            try
            {
                Endereco endereco1 = await _kindleDB.Enderecos.Find(endereco.ID);
                return SingleResponseFactory<Endereco>.CreateSuccessSingleResponse(endereco1);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Endereco>.CreateFailureSingleResponse(ex);
            }
        }

    }
}
