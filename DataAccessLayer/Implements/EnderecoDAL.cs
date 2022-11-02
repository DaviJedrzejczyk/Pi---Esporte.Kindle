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
    public class EnderecoDAL : IEnderecoDALService
    {
        readonly string connectionString = ConnectionString._connectionString;
        public async Task<Response> Insert(Endereco endereco)
        {
            string sql = $"INSERT INTO ENDERECOS (CEP,NUMERO_CASA,BAIRRO,CIDADE,COMPLEMENTO,PONTO_REFERENCIA,ESTADO_ID,RUA) VALUES (@CEP,@NUMERO_CASA,@BAIRRO,@CIDADE,@COMPLEMENTO,@PONTO_REFERENCIA,@ESTADO_ID,@RUA); SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@CEP", endereco.CEP);
            command.Parameters.AddWithValue("@NUMERO_CASA", endereco.Numero);
            command.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);
            command.Parameters.AddWithValue("@RUA", endereco.Rua);
            command.Parameters.AddWithValue("@CIDADE", endereco.Cidade);
            command.Parameters.AddWithValue("@PONTO_REFERENCIA", endereco.PontoReferencia);
            command.Parameters.AddWithValue("@ESTADO_ID", endereco.Estado.ID);
            command.Parameters.AddWithValue("@COMPLEMENTO", endereco.Complemento);
            try
            {
                await connection.OpenAsync();
                endereco.ID = Convert.ToInt32(command.ExecuteScalar());
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_FUNCIONARIOS_ENDERECO"))
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

        public async Task<Response> Update(Endereco endereco)
        {
            string sql = $"UPDATE ENDERECOS SET CEP = @CEP, NUMERO_CASA = @NUMERO_CASA, BAIRRO = @BAIRRO, RUA = @RUA, COMPLEMENTO = @COMPLEMENTO, CIDADE = @CIDADE, PONTO_REFERENCIA = @PONTO_REFERENCIA, ESTADO_ID = ESTADO_ID WHERE ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@CEP", endereco.CEP);
            command.Parameters.AddWithValue("@NUMERO_CASA", endereco.Numero);
            command.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);
            command.Parameters.AddWithValue("@ESTADO_ID", endereco.Estado.ID);
            command.Parameters.AddWithValue("@CIDADE", endereco.Cidade);
            command.Parameters.AddWithValue("@PONTO_REFERENCIA", endereco.PontoReferencia);
            command.Parameters.AddWithValue("@RUA", endereco.Rua);
            command.Parameters.AddWithValue("@COMPLEMENTO", endereco.Complemento);
            command.Parameters.AddWithValue("@ID", endereco.ID);
            try
            {
                await connection.OpenAsync();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public async Task<Response> Delete(int id)
        {

            string sql = "DELETE FROM ENDERECOS WHERE ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                await connection.OpenAsync();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<DataResponse<Endereco>> GetAll()
        {
            string sql = $"SELECT ID,CEP,NUMERO_CASA,BAIRRO,RUA,CIDADE,COMPLEMENTO,PONTO_REFERENCIA,ESTADO_ID FROM ENDERECOS";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                List<Endereco> enderecos = new();
                while (reader.Read())
                {
                    Endereco endereco = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        CEP = Convert.ToString(reader["CEP"]),
                        Rua = Convert.ToString(reader["RUA"]),
                        Complemento = Convert.ToString(reader["COMPLEMENTO"]),
                        Numero = Convert.ToString(reader["NUMERO_CASA"]),
                        Bairro = Convert.ToString(reader["BAIRRO_ID"]),
                        Cidade = Convert.ToString(reader["CIDADE"]),
                        Estado = (Estado)reader["ESTADO_ID"],
                        PontoReferencia = Convert.ToString(reader["PONTO_REFERENCIA"])
                    };
                    enderecos.Add(endereco);
                }
                return DataResponseFactory<Endereco>.CreateInstance().CreateSuccessResponse(enderecos);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Endereco>.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<SingleResponse<Endereco>> GetById(int id)
        {
            string sql = $"SELECT ID,CEP,NUMERO_CASA,BAIRRO,RUA,CIDADE,COMPLEMENTO,PONTO_REFERENCIA,ESTADO_ID FROM ENDERECOS WHERE ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.Read())
                {
                    Endereco endereco = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        CEP = Convert.ToString(reader["CEP"]),
                        Rua = Convert.ToString(reader["RUA"]),
                        Complemento = Convert.ToString(reader["COMPLEMENTO"]),
                        Numero = Convert.ToString(reader["NUMERO_CASA"]),
                        Bairro = Convert.ToString(reader["BAIRRO"]),
                        Cidade = Convert.ToString(reader["CIDADE"]),
                        EstadoID = Convert.ToInt32(reader["ESTADO_ID"]),
                        PontoReferencia = Convert.ToString(reader["PONTO_REFERENCIA"])
                    };
                    return SingleResponseFactory<Endereco>.CreateInstance().CreateSuccessSingleResponse(endereco);
                }
                return SingleResponseFactory<Endereco>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Endereco>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }


    }
}
