using DataAccessLayer.Interfaces;
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
    public class EstadoDAL : IEstadoDALService
    {
        private readonly string connectionString = ConnectionString._connectionString;
        public async Task<Response> Insert(Estado estado)
        {
            string sql = $"INSERT INTO ESTADOS (NOME_ESTADO,SIGLA) VALUES (@NOME_ESTADO,@SIGLA)";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_ESTADO", estado.NomeCompleto);
            command.Parameters.AddWithValue("@SIGLA", estado.Unidade_Federal);
            try
            {
                connection.Open();
                await command.ExecuteNonQueryAsync();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_ESTADOS_SIGLA"))
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

        public async Task<Response> Update(Estado estado)
        {

            string sql = $"UPDATE ESTADOS SET NOME_ESTADO = @NOME_ESTADO, SIGLA = @SIGLA WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME_ESTADO", estado.NomeCompleto);
            command.Parameters.AddWithValue("@SIGLA", estado.Unidade_Federal);
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
                if (ex.Message.Contains("UQ_ESTADOS_SIGLA"))
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
            string sql = "DELETE FROM ESTADOS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = await command.ExecuteNonQueryAsync();
                if (qtdLinhasExcluidas == 1)
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_CIDADES_ESTADO"))
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

        public DataResponse<Estado> GetAll()
        {
            string sql = $"SELECT ID,NOME_ESTADO,SIGLA FROM ESTADOS";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Estado> estados = new();
                while (reader.Read())
                {
                    Estado estado = new Estado();
                    estado.ID = Convert.ToInt32(reader["ID"]);
                    estado.NomeCompleto = Convert.ToString(reader["NOME_ESTADO"]);
                    estado.Unidade_Federal = Convert.ToString(reader["SIGLA"]);
                    estados.Add(estado);
                }
                return DataResponseFactory<Estado>.CreateInstance().CreateSuccessResponse(estados);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Estado>.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<SingleResponse<Estado>> GetById(int id)
        {
            string sql = $"SELECT ID,NOME_ESTADO,SIGLA FROM ESTADOS WHERE ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.Read())
                {
                    Estado estado = new Estado();
                    estado.ID = Convert.ToInt32(reader["ID"]);
                    estado.NomeCompleto = Convert.ToString(reader["NOME_ESTADO"]);
                    estado.Unidade_Federal = Convert.ToString(reader["SIGLA"]);
                    return SingleResponseFactory<Estado>.CreateInstance().CreateSuccessSingleResponse(estado);
                }
                return SingleResponseFactory<Estado>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Estado>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }


    }
}
