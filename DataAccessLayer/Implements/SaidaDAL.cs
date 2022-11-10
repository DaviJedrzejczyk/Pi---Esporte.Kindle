using DataAccessLayer.Interfaces;
using Entities;
using Entities.Enums;
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
    public class SaidaDAL : ISaidaDALService
    {
        private readonly string connectionString = ConnectionString._connectionString;  
        public async Task<Response> Insert(Saida saida)
        {
            string sql = $"INSERT INTO SAIDAS (VALOR,CLIENTE_ID,FUNCIONARIOS_ID,DATA_SAIDA,FORMA_PAGAMENTO,VALOR_TOTAL) VALUES (@VALOR,@CLIENTE_ID,@FUNCIONARIO_ID,@DATA_SAIDA,@FORMA_PAGAMENTO,@VALOR_TOTAL); SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@VALOR", saida.Valor);
            command.Parameters.AddWithValue("@VALOR_TOTAL", saida.Valor_Total);
            command.Parameters.AddWithValue("@CLIENTE_ID", saida.ClienteID);
            command.Parameters.AddWithValue("@FUNCIONARIO_ID", saida.FuncionarioID);
            command.Parameters.AddWithValue("@DATA_SAIDA", saida.DataSaida);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTO", saida.FormaPagamento);
            try
            {
                connection.Open();
                saida.ID = Convert.ToInt32(await command.ExecuteScalarAsync());
                
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
        public async Task<DataResponse<SaidaView>> GetAll()
        {
            string sql = $"SELECT S.ID,S.VALOR,S.DATA_SAIDA,S.VALOR_TOTAL,S.FORMA_PAGAMENTO,C.NOME AS CLIENTES,FU.NOME AS FUNCIONARIOS,FORMA_PAGAMENTO FROM SAIDAS S INNER JOIN CLIENTES C ON S.CLIENTE_ID = C.ID INNER JOIN FUNCIONARIOS FU ON S.FUNCIONARIOS_ID = FU.ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();
                List<SaidaView> saidas = new();
                while (reader.Read())
                {
                    SaidaView saida = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Valor = Convert.ToDouble(reader["VALOR"]),
                        Cliente = Convert.ToString(reader["CLIENTES"]),
                        Funcionario = Convert.ToString(reader["FUNCIONARIOS"]),
                        DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]),
                        FormaPagamento = (FormaPagamento)reader["FORMA_PAGAMENTO"],
                        ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"])
                    };

                    saidas.Add(saida);
                }
                return DataResponseFactory<SaidaView>.CreateInstance().CreateSuccessResponse(saidas);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<SaidaView>.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public SingleResponse<SaidaView> GetById(int id)
        {
            string sql = $"SELECT ID,VALOR,CLIENTE_ID,FUNCIONARIOS_ID,DATA_SAIDA,FORMA_PAGAMENTO,VALOR_TOTAL FROM SAIDAS WHERE ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    SaidaView saida = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Valor = Convert.ToDouble(reader["VALOR"]),
                        Cliente = Convert.ToString(reader["CLIENTE_ID"]),
                        Funcionario = Convert.ToString(reader["FUNCIONARIOS_ID"]),
                        DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]),
                        FormaPagamento = (FormaPagamento)reader["FORMA_PAGAMENTO"],
                        ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"])
                    };
                    return SingleResponseFactory<SaidaView>.CreateInstance().CreateSuccessSingleResponse(saida);
                }
                return SingleResponseFactory<SaidaView>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<SaidaView>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public SingleResponse<SaidaView> GetSaidaViewById(int id)
        {
            string sql = $"SELECT S.ID,S.VALOR,S.DATA_SAIDA,S.VALOR_TOTAL,S.FORMA_PAGAMENTO,C.NOME AS CLIENTES,FU.NOME AS FUNCIONARIOS,S.FORMA_PAGAMENTO FROM SAIDAS S INNER JOIN CLIENTES C ON S.CLIENTE_ID = C.ID INNER JOIN FUNCIONARIOS FU ON S.FUNCIONARIOS_ID = FU.ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    SaidaView saida = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Valor = Convert.ToDouble(reader["VALOR"]),
                        Cliente = Convert.ToString(reader["CLIENTES"]),
                        Funcionario = Convert.ToString(reader["FUNCIONARIOS"]),
                        DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]),
                        FormaPagamento = (FormaPagamento)reader["FORMA_PAGAMENTO"],
                        ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"])
                    };
                    return SingleResponseFactory<SaidaView>.CreateInstance().CreateSuccessSingleResponse(saida);
                }
                return SingleResponseFactory<SaidaView>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<SaidaView>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<SingleResponse<List<SaidaView>>> GetByDate(FilterSaida saida)
        {
            string sql = @$"SELECT  S.ID, S.VALOR,
		C.NOME 'CLIENTE',
		F.NOME 'FUNCIONARIO', 
		S.DATA_SAIDA,
		S.FORMA_PAGAMENTO,
		S.VALOR_TOTAL,
		S.DESCONTO
FROM    SAIDAS S
        INNER JOIN
        CLIENTES C ON S.CLIENTE_ID = C.ID

        INNER JOIN

        FUNCIONARIOS F ON S.FUNCIONARIO_ID = F.ID
        
        WHERE 1 = 1 AND DATA_SAIDA BETWEEN @DATA_INICIAL AND @DATA_FINAL";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@DATA_INICIAL", saida.Inicio);
            command.Parameters.AddWithValue("@DATA_FINAL", saida.Fim);
            try
            {
                connection.Open();
                SqlDataReader reader = await command.ExecuteReaderAsync();

                List<SaidaView> saidasView = new();
                while (reader.Read())
                {
                    SaidaView saidaView = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Valor = Convert.ToDouble(reader["VALOR"]),
                        Cliente = Convert.ToString(reader["CLIENTE"]),
                        Funcionario = Convert.ToString(reader["FUNCIONARIO"]),
                        DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]),
                        FormaPagamento = (FormaPagamento)reader["FORMA_PAGAMENTO"],
                        ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"])
                    };
                    saidasView.Add(saidaView);
                }
                return SingleResponseFactory<List<SaidaView>>.CreateInstance().CreateSuccessSingleResponse(saidasView); 
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<List<SaidaView>>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
