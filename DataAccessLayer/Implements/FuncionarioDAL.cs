using DataAccessLayer.Interfaces;
using Entities;
using Entities.Enums;
using Shared;
using Shared.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer.Implements
{
    public class FuncionarioDAL : IFuncionarioDALService
    {
        private string _connection = ConnectionString._connectionString;
        public async Task<Response> Insert(Funcionario funcionario)
        {
            string sql = $"INSERT INTO FUNCIONARIOS (NOME,SOBRENOME,CPF,RG,EMAIL,SENHA,TELEFONE,GENERO,DATA_NASCIMENTO,IDADE, NIVEL_ACESSO,ENDERECO_ID) VALUES (@NOME,@SOBRENOME,@CPF,@RG,@EMAIL,@SENHA,@TELEFONE,@GENERO,@DATA_NASCIMENTO,@IDADE,@NIVEL_ACESSO,@ENDERECO_ID)";
            SqlConnection connection = new(_connection);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@SOBRENOME", funcionario.Sobrenome);
            command.Parameters.AddWithValue("@CPF", funcionario.CPF);
            command.Parameters.AddWithValue("@RG", funcionario.RG);
            command.Parameters.AddWithValue("@DATA_NASCIMENTO", funcionario.DataNascimento);
            command.Parameters.AddWithValue("@TELEFONE", funcionario.Telefone);
            command.Parameters.AddWithValue("@IDADE", funcionario.Idade);
            command.Parameters.AddWithValue("@EMAIL", funcionario.Email);
            command.Parameters.AddWithValue("@GENERO", funcionario.Genero);
            command.Parameters.AddWithValue("@SENHA", funcionario.Senha);
            command.Parameters.AddWithValue("@NIVEL_ACESSO", funcionario.Nivel_Acesso);
            command.Parameters.AddWithValue("@ENDERECO_ID", funcionario.EnderecoId);
            try
            {
                connection.Open();
                await command.ExecuteNonQueryAsync();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UQ_FUNCIONARIOS_EMAIL"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse(ex.Message);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIOS_CPF"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse(ex.Message);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIOS_RG"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse(ex.Message);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIOS_TELEFONE"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse(ex.Message);
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<Response> Update(Funcionario funcionario)
        {
            string sql = $"UPDATE FUNCIONARIOS SET NOME = @NOME,SOBRENOME = @SOBRENOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE, GENERO = @GENERO,NIVEL_ACESSO = @NIVEL_ACESSO WHERE ID = @ID";
            SqlConnection connection = new(_connection);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@NOME", funcionario.Nome);
            command.Parameters.AddWithValue("@EMAIL", funcionario.Email);
            command.Parameters.AddWithValue("@TELEFONE", funcionario.Telefone);
            command.Parameters.AddWithValue("@GENERO", funcionario.Genero);
            command.Parameters.AddWithValue("@NIVEL_ACESSO", funcionario.Nivel_Acesso);
            command.Parameters.AddWithValue("@ID", funcionario.ID);
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
                if (ex.Message.Contains("UQ_FUNCIONARIOS_EMAIL"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse(ex.Message);
                }
                if (ex.Message.Contains("UQ_FUNCIONARIOS_TELEFONE"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse(ex.Message);
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
            string sql = "DELETE FROM FUNCIONARIOS WHERE ID = @ID";
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
                if (ex.Message.Contains("FK_ENTRADAS_FUNCIONARIOS"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse(ex.Message);
                }
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<DataResponse<Funcionario>> GetAll()
        {
            string sql = $"SELECT ID,NOME,SOBRENOME,CPF,RG,TELEFONE,EMAIL FROM FUNCIONARIOS";
            SqlConnection connection = new SqlConnection(_connection);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                List<Funcionario> funcionarios = new();
                while (reader.Read())
                {
                    Funcionario funcionario = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nome = Convert.ToString(reader["NOME"]),
                        Sobrenome = Convert.ToString(reader["SOBRENOME"]),
                        Idade = Convert.ToInt32(reader["IDADE"]),
                        EnderecoId = Convert.ToInt32(reader["ENDERECO_ID"]),
                        DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]),
                        Genero = (Genero)reader["GENERO"],
                        Nivel_Acesso = (TipoFuncionario)reader["NIVEL_ACESSO"],
                        CPF = Convert.ToString(reader["CPF"]),
                        Rg = Convert.ToString(reader["RG"]),
                        Telefone = Convert.ToString(reader["TELEFONE"]),
                        Email = Convert.ToString(reader["EMAIL"])
                    };
                    funcionarios.Add(funcionario);
                }
                return DataResponseFactory<Funcionario>.CreateInstance().CreateSuccessResponse(funcionarios);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Funcionario>.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<SingleResponse<Funcionario>> GetById(int id)
        {
            string sql = $"SELECT ID,NOME,SOBRENOME,NIVEL_ACESSO,TELEFONE,EMAIL,GENERO,ENDERECO_ID,SENHA,DATA_NASCIMENTO,IDADE FROM FUNCIONARIOS WHERE ID = @ID";
            SqlConnection connection = new(_connection);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.Read())
                {
                    Funcionario funcionario = new()
                    {

                        ID = Convert.ToInt32(reader["ID"]),
                        Nome = Convert.ToString(reader["NOME"]),
                        Sobrenome = Convert.ToString(reader["SOBRENOME"]),
                        Nivel_Acesso = (TipoFuncionario)reader["NIVEL_ACESSO"],
                        Telefone = Convert.ToString(reader["TELEFONE"]),
                        Email = Convert.ToString(reader["EMAIL"]),
                        Senha = Convert.ToString(reader["SENHA"]),
                        DataNascimento = Convert.ToDateTime(reader["DATA_NASCIMENTO"]),
                        Idade = Convert.ToInt32(reader["IDADE"]),
                        Genero = (Genero)reader["GENERO"],
                        EnderecoId = Convert.ToInt32(reader["ENDERECO_ID"])
                    };
                    return SingleResponseFactory<Funcionario>.CreateInstance().CreateSuccessSingleResponse(funcionario);
                }
                return SingleResponseFactory<Funcionario>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Funcionario>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<SingleResponse<Funcionario>> GetLogin(Funcionario funcionario)
        {
            string sql = "SELECT EMAIL, SENHA, NVIEL_FUNCIONARIO FROM FUNCIONARIOS WHERE EMAIL = @EMAIL";
            SqlConnection connection = new(_connection);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@EMAIL", funcionario.Email);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.Read())
                {
                    Funcionario funcionario1 = new()
                    {
                        Email = Convert.ToString(reader["EMAIL"]),
                        Senha = Convert.ToString(reader["SENHA"]),
                        Nivel_Acesso = (TipoFuncionario)reader["NIVEL_ACESSO"]
                    };
                    return SingleResponseFactory<Funcionario>.CreateInstance().CreateSuccessSingleResponse(funcionario1);
                }
                return SingleResponseFactory<Funcionario>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Funcionario>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }


    }
}
