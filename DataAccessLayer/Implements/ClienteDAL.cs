using DataAccessLayer.Interfaces;
using Entities;
using Shared.Factory;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;
using System.Data.SqlClient;

namespace DataAccessLayer.Implements
{
    public class ClienteDAL : IClienteDALService
    {
        private string _connectionString = ConnectionString._connectionString;
        public Response Insert(Cliente cliente)
        {
            string sql = $"INSERT INTO CLIENTES (NOME,SOBRENOME,RG,CPF,TELEFONE,EMAIL,GENERO,DATA_NASCIMENTO) VALUES (@NOME,@SOBRENOME,@RG,@CPF,@TELEFONE,@EMAIL,@GENERO,@DATA_NASCIMENTO)";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@SOBRENOME", cliente.Sobrenome);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            //command.Parameters.AddWithValue("@TIPO_CLIENTE_ID", cliente.TipoClienteId);
            command.Parameters.AddWithValue("@GENERO", cliente.Genero);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse();
            }
            finally
            {
                connection.Dispose();
            }
        }

        public Response Update(Cliente cliente)
        {
            string sql = $"UPDATE CLIENTES SET NOME = @NOME,SOBRENOME = @SOBRENOME, RG = @RG, CPF = @CPF,EMAIL = @EMAIL, TELEFONE = @TELEFONE,GENERO = @GENERO,DATA_NASCIMENTO = @DATA_NASCIMENTO WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@NOME", cliente.Nome);
            command.Parameters.AddWithValue("@SOBRENOME", cliente.Sobrenome);
            command.Parameters.AddWithValue("@RG", cliente.RG);
            command.Parameters.AddWithValue("@CPF", cliente.CPF);
            command.Parameters.AddWithValue("@EMAIL", cliente.Email);
            command.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
            //command.Parameters.AddWithValue("@TIPO_CLIENTE_ID", cliente.TipoClienteId);
            command.Parameters.AddWithValue("@GENERO", cliente.Genero);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            command.Parameters.AddWithValue("@ID", cliente.ID);
            try
            {
                connection.Open();
                int qtdRegistrosAlterados = command.ExecuteNonQuery();
                if (qtdRegistrosAlterados != 1)
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_CLIENTES_EMAIL"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                if (ex.Message.Contains("UQ_CLIENTES_CPF"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse();
            }
            finally
            {
                connection.Dispose();
            }
        }
        public Response Delete(int id)
        {
            string sql = "DELETE FROM CLIENTES WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                int qtdLinhasExcluidas = command.ExecuteNonQuery();
                if (qtdLinhasExcluidas == 1)
                {
                    return ResponseFactory.CreateInstance().CreateSuccessResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_SAIDAS_CLIENTE"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse();
            }
            finally
            {
                connection.Dispose();
            }
        }
        public DataResponse<Cliente> GetAll()
        {
            string sql = $"SELECT ID,NOME,SOBRENOME,RG,CPF,TELEFONE,EMAIL, GENERO, DATA_NASCIMENTO FROM CLIENTES";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.Sobrenome = Convert.ToString(reader["SOBRENOME"]);
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Telefone = Convert.ToString(reader["TELEFONE"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    //cliente.TipoClienteId = Convert.ToInt32(reader["TIPO_CLIENTE_ID"]);
                    cliente.Genero = (Genero)reader["GENERO"];
                    cliente.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    clientes.Add(cliente);
                }
                return DataResponseFactory<Cliente>.CreateInstance().CreateSuccessResponse(clientes);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Cliente>.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<Cliente> GetById(int id)
        {
            string sql = $"SELECT ID,NOME, SOBRENOME,RG,CPF,TELEFONE,EMAIL,GENERO, DATA_NASCIMENTO FROM CLIENTES WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.ID = Convert.ToInt32(reader["ID"]);
                    cliente.Nome = Convert.ToString(reader["NOME"]);
                    cliente.Sobrenome = Convert.ToString(reader["SOBRENOME"]);
                    cliente.RG = Convert.ToString(reader["RG"]);
                    cliente.CPF = Convert.ToString(reader["CPF"]);
                    cliente.Telefone = Convert.ToString(reader["TELEFONE1"]);
                    cliente.Email = Convert.ToString(reader["EMAIL"]);
                    //cliente.TipoClienteId = Convert.ToInt32(reader["TIPO_CLIENTE_ID"]);
                    cliente.Genero = (Genero)reader["GENEROS"];
                    cliente.DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]);
                    return SingleResponseFactory<Cliente>.CreateInstance().CreateSuccessSingleResponse(cliente);
                }
                return SingleResponseFactory<Cliente>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Cliente>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

      
    }
}
