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
    public class FuncionarioDAL : IFuncionarioDALService
    {
        private readonly PIKindleDB pIKindleDB;
        public FuncionarioDAL(PIKindleDB pI)
        {
            pIKindleDB = pI;
        }
        public async Task<Response> Insert(Funcionario funcionario)
        {
            pIKindleDB.Add(funcionario);
            try
            {
                await pIKindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse(); 
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public async Task<Response> Update(Funcionario funcionario)
        {
            Funcionario? funcionario1 = pIKindleDB.Funcionarios.Find(funcionario.ID);
            funcionario1.Nome = funcionario.Nome;
            funcionario1.Sobrenome = funcionario.Sobrenome;
            funcionario1.Telefone = funcionario.Telefone;
            funcionario1.Senha = funcionario.Senha;
            funcionario1.Email = funcionario.Email;
            funcionario1.Genero = funcionario.Genero;
            funcionario1.Nivel_Acesso = funcionario.Nivel_Acesso;
            try
            {
                await pIKindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public async Task<Response> Delete(Funcionario funcionario)
        {
            Funcionario? funcionario1 = pIKindleDB.Funcionarios.Find(funcionario.ID);
            pIKindleDB.Remove(funcionario1);
            try
            {
                await pIKindleDB.SaveChangesAsync();
                return ResponseFactory.CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateFailureResponse(ex);
            }
        }

        public async Task<DataResponse<Funcionario>> GetAll()
        {
            try
            {
                List<Funcionario> funcionarios = await pIKindleDB.Funcionarios.ToListAsync();
                return DataResponseFactory<Funcionario>.CreateSuccessResponse(funcionarios);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Funcionario>.CreateFailureResponse(ex);
            }
        }

        public async Task<SingleResponse<Funcionario>> GetById(Funcionario funcionario)
        {
            try
            {
                Funcionario? funcionario1 = await pIKindleDB.Funcionarios.FindAsync(funcionario.ID);
                return SingleResponseFactory<Funcionario>.CreateSuccessSingleResponse(funcionario);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Funcionario>.CreateFailureSingleResponse(ex);
            }
        }

        public async Task<SingleResponse<Funcionario>> GetLogin(Funcionario funcionario)
        {
            try
            {
                Funcionario? login = await pIKindleDB.Funcionarios.FirstOrDefaultAsync(f => f.Email == funcionario.Email && f.Senha == funcionario.Senha);
                if(login == null)
                {
                    return SingleResponseFactory<Funcionario>.CreateFailureSingleResponse();
                }
                return SingleResponseFactory<Funcionario>.CreateSuccessSingleResponse(login);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Funcionario>.CreateFailureSingleResponse(ex);
            }
        }

       
    }
}
