using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using Shared.Factory;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implements
{
    public class CategoriaDAL : ICategoriaDALService
    {
        private readonly string _connectionString = ConnectionString._connectionString;
        public async Task<Response> Insert(Categoria item)
        {
            string sql = $"INSERT INTO CATEGORIAS(NOME,DESCRICAO) VALUES(@NOME,@DESCRICAO)";
            SqlConnection connection = new(_connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", item.Descricao);
            try
            {
                connection.Open();
                await command.ExecuteNonQueryAsync();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_NOME_CATEGORIAS"))
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

        public async Task<Response> Update(Categoria item)
        {
            string sql = $"UPDATE CATEGORIAS SET NOME = @NOME, DESCRICAO = @DESCRICAO WHERE ID = @ID";
            SqlConnection connection = new(_connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@NOME", item.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", item.Descricao);
            command.Parameters.AddWithValue("@ID",item.Id);
            try
            {
                connection.Open();
                int qtdAlterado = await command.ExecuteNonQueryAsync();
                if (qtdAlterado != 1)
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_NOME_CATEGORIAS"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
        }
        public async Task<Response> Delete(Categoria item)
        {
            string sql = $"DELETE FROM CATEGORIAS WHERE ID = @ID";
            SqlConnection connection = new(_connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", item.Id);
            try
            {
                connection.Open();
                int qtdAlterado = await command.ExecuteNonQueryAsync();
                if (qtdAlterado == 1)
                {
                    return ResponseFactory.CreateInstance().CreateSuccessResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
        }

        public async Task<DataResponse<Categoria>> GetAll()
        {
            string sql = $"SELECT ID, NOME, DESCRICAO FROM CATEGORIAS";
            SqlConnection connection = new(_connectionString);
            SqlCommand command = new(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                List<Categoria> categorias = new();
                while (reader.Read())
                {
                    Categoria categoria = new()
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Nome = Convert.ToString(reader["NOME"]),
                        Descricao = Convert.ToString(reader["DESCRICAO"])
                    };
                    categorias.Add(categoria);
                }
                return DataResponseFactory<Categoria>.CreateInstance().CreateSuccessResponse(categorias);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Categoria>.CreateInstance().CreateFailureResponse(ex);
            }
        }

        public async Task<SingleResponse<Categoria>> GetById(int id)
        {
            string sql = $"SELECT ID = @ID, NOME = @NOME, DESCRICAO = @DESCRICAO FROM CATEGORIAS WHERE ID = @ID";
            SqlConnection connection = new(_connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.Read())
                {
                    Categoria categoria = new()
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Nome = Convert.ToString(reader["NOME"]),
                        Descricao = Convert.ToString(reader["DESCRICAO"])
                    };
                    return SingleResponseFactory<Categoria>.CreateInstance().CreateSuccessSingleResponse(categoria);
                }
                return SingleResponseFactory<Categoria>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Categoria>.CreateInstance().CreateFailureSingleResponse(ex);
            }
        }

    
    }
}
