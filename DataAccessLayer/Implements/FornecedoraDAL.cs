﻿using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using Shared.Factory;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class FornecedoraDAL : IFornecedoraDALService
    {
        private string _connection = ConnectionString._connectionString;

        public async Task<Response> Insert(Fornecedor fornecedor)
        {
            string sql = $"INSERT INTO FORNECEDORES (RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL) VALUES (@RAZAO_SOCIAL,@CNPJ,@NOME_CONTATO,@TELEFONE,@EMAIL)";
            SqlConnection connection = new(_connection);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.Razao_Social);
            command.Parameters.AddWithValue("@CNPJ", fornecedor.Cnpj);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.Nome_Contato);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            try
            {
                connection.Open();
               await command.ExecuteNonQueryAsync();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDORES_EMAIL"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                if (ex.Message.Contains("UQ_FORNECEDORES_CNPJ"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<Response> Update(Fornecedor fornecedor)
        {
            string sql = $"UPDATE FORNECEDORES SET RAZAO_SOCIAL = @RAZAO_SOCIAL, EMAIL = @EMAIL, TELEFONE = @TELEFONE, NOME_CONTATO = @NOME_CONTATO WHERE ID = @ID";
            SqlConnection connection = new(_connection);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@RAZAO_SOCIAL", fornecedor.Razao_Social);
            command.Parameters.AddWithValue("@EMAIL", fornecedor.Email);
            command.Parameters.AddWithValue("@TELEFONE", fornecedor.Telefone);
            command.Parameters.AddWithValue("@NOME_CONTATO", fornecedor.Nome_Contato);
            command.Parameters.AddWithValue("@ID", fornecedor.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = await command.ExecuteNonQueryAsync();
                if (qtdRegistrosAlterados != 1)
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FORNECEDORES_EMAIL"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                if (ex.Message.Contains("UQ_FORNECEDORES_CNPJ"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public async Task<Response> Delete(int id)
        {
            string sql = "DELETE FROM FORNECEDORES WHERE ID = @ID";
            SqlConnection connection = new(_connection);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = await command.ExecuteNonQueryAsync();
                if (qtdLinhasExcluidas == 1)
                {
                    return ResponseFactory.CreateInstance().CreateSuccessResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_ENTRADAS_FORNECEDOR"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public DataResponse<Fornecedor> GetAll()
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL FROM FORNECEDORES";
            SqlConnection connection = new(_connection);
            SqlCommand command = new(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Fornecedor> fornecedores = new();
                while (reader.Read())
                {
                    Fornecedor fornecedor = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Razao_Social = Convert.ToString(reader["RAZAO_SOCIAL"]),
                        Cnpj = Convert.ToString(reader["CNPJ"]),
                        Nome_Contato = Convert.ToString(reader["NOME_CONTATO"]),
                        Telefone = Convert.ToString(reader["TELEFONE"]),
                        Email = Convert.ToString(reader["EMAIL"])
                    };
                    fornecedores.Add(fornecedor);
                }
                return DataResponseFactory<Fornecedor>.CreateInstance().CreateSuccessResponse(fornecedores);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Fornecedor>.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<SingleResponse<Fornecedor>> GetById(int id)
        {
            string sql = $"SELECT ID,RAZAO_SOCIAL,CNPJ,NOME_CONTATO,TELEFONE,EMAIL FROM FORNECEDORES WHERE ID = @ID";
            SqlConnection connection = new(_connection);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.Read())
                {
                    Fornecedor fornecedor = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Razao_Social = Convert.ToString(reader["RAZAO_SOCIAL"]),
                        Cnpj = Convert.ToString(reader["CNPJ"]),
                        Nome_Contato = Convert.ToString(reader["NOME_CONTATO"]),
                        Telefone = Convert.ToString(reader["TELEFONE"]),
                        Email = Convert.ToString(reader["EMAIL"])
                    };
                    return SingleResponseFactory<Fornecedor>.CreateInstance().CreateSuccessSingleResponse(fornecedor);
                }
                return SingleResponseFactory<Fornecedor>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Fornecedor>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }


    }
}

