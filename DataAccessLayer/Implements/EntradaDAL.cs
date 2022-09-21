using DataAccessLayer.Interfaces;
using Entities;
using Entities.Filters;
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
    public class EntradaDAL : IEntradaDALService
    {
        private readonly string connectionString = ConnectionString._connectionString;
        public async Task<Response> Insert(Entrada entrada)
        {
            string sql = $"INSERT INTO ENTRADAS (PRECO,FORNECEDOR_ID,FUNCIONARIO_ID,DATA_ENTRADA) VALUES (@PRECO,@FORNECEDOR_ID,@FUNCIONARIO_ID,@DATA_ENTRADA); SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@PRECO", entrada.Valor);
            command.Parameters.AddWithValue("@FORNECEDOR_ID", entrada.FornecedorID);
            command.Parameters.AddWithValue("@FUNCIONARIO_ID", entrada.FuncionarioId);
            command.Parameters.AddWithValue("@DATA_ENTRADA", entrada.DataEntrada);
            try
            {
                await connection.OpenAsync();
                entrada.ID = Convert.ToInt32(command.ExecuteScalar());
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
        public async Task<DataResponse<EntradaView>> GetAll()
        {
            string sql = $"SELECT E.ID,E.PRECO,E.DATA_ENTRADA,FO.RAZAO_SOCIAL AS FORNECEDORES,FU.NOME AS FUNCIONARIOS FROM ENTRADAS E INNER JOIN FORNECEDORES FO ON E.FORNECEDOR_ID = FO.ID INNER JOIN FUNCIONARIOS FU ON E.FUNCIONARIO_ID = FU.ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<EntradaView> entradas = new();
                while (reader.Read())
                {
                    EntradaView entrada = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Valor = Convert.ToDouble(reader["PRECO"]),
                        Fornecedor = Convert.ToString(reader["FORNECEDORES"]),
                        Funcionario = Convert.ToString(reader["FUNCIONARIOS"]),
                        DataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"])
                    };
                    entradas.Add(entrada);
                }
                return DataResponseFactory<EntradaView>.CreateInstance().CreateSuccessResponse(entradas);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<EntradaView>.CreateInstance().CreateFailureResponse();
            }
            finally
            {
                connection.Dispose();
            }
        }
        public async Task<SingleResponse<EntradaView>> GetById(int id)
        {
            string sql = $"SELECT E.ID,E.PRECO,E.DATA_ENTRADA,FO.RAZAO_SOCIAL AS FORNECEDORES,FU.NOME AS FUNCIONARIOS FROM ENTRADAS E INNER JOIN FORNECEDORES FO ON E.FORNECEDOR_ID = FO.ID INNER JOIN FUNCIONARIOS FU ON E.FUNCIONARIO_ID = FU.ID WHERE E.ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    EntradaView entrada = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Valor = Convert.ToDouble(reader["PRECO"]),
                        Fornecedor = Convert.ToString(reader["FORNECEDORES"]),
                        Funcionario = Convert.ToString(reader["FUNCIONARIOS"]),
                        DataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"])
                    };
                    return SingleResponseFactory<EntradaView>.CreateInstance().CreateSuccessSingleResponse(entrada);
                }
                return SingleResponseFactory<EntradaView>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<EntradaView>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public async Task<SingleResponse<List<EntradaView>>> GetByDate(FilterEntrada filterEntrada)
        {
            string sql = $"SELECT E.ID,E.PRECO,E.DATA_ENTRADA,FO.RAZAO_SOCIAL AS FORNECEDORES, FU.NOME AS FUNCIONARIOS FROM ENTRADAS E INNER JOIN FORNECEDORES FO ON E.FORNECEDOR_ID = FO.ID INNER JOIN FUNCIONARIOS FU ON E.FUNCIONARIO_ID = FU.ID WHERE 1 = 1 AND DATA_ENTRADA BETWEEN @DATA_INICIAL AND @DATA_FINAL";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@DATA_INICIAL", filterEntrada.Inicio);
            command.Parameters.AddWithValue("@DATA_FINAL", filterEntrada.Fim);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<EntradaView> entradas = new();
                while (reader.Read())
                {
                    EntradaView entrada = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Valor = Convert.ToDouble(reader["PRECO"]),
                        Fornecedor = Convert.ToString(reader["FORNECEDORES"]),
                        Funcionario = Convert.ToString(reader["FUNCIONARIOS"]),
                        DataEntrada = Convert.ToDateTime(reader["DATA_ENTRADA"])
                    };
                    entradas.Add(entrada);
                }
                return SingleResponseFactory<List<EntradaView>>.CreateInstance().CreateSuccessSingleResponse(entradas);
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<List<EntradaView>>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
