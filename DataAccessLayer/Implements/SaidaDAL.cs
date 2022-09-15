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
        private string connectionString = ConnectionString._connectionString;  
        public async Task<Response> Insert(Saida saida)
        {
            string sql = $"INSERT INTO SAIDAS (VALOR,CLIENTE_ID,FUNCIONARIO_ID,DATA_SAIDA,FORMA_PAGAMENTO_ID,VALOR_TOTAL,DESCONTO) VALUES (@VALOR,@CLIENTE_ID,@FUNCIONARIO_ID,@DATA_SAIDA,@FORMA_PAGAMENTO_ID,@VALOR_TOTAL,@DESCONTO); SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@VALOR", saida.Valor);
            command.Parameters.AddWithValue("@VALOR_TOTAL", saida.Valor_Total);
            command.Parameters.AddWithValue("@CLIENTE_ID", saida.ClienteID);
            command.Parameters.AddWithValue("@FUNCIONARIO_ID", saida.FuncionarioID);
            command.Parameters.AddWithValue("@DATA_SAIDA", saida.DataSaida);
            command.Parameters.AddWithValue("@FORMA_PAGAMENTO_ID", saida.FormaPagamento);
            try
            {
                connection.Open();
                saida.ID = Convert.ToInt32(command.ExecuteScalar());
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
            string sql = $"SELECT S.ID,S.VALOR,S.DATA_SAIDA,S.VALOR_TOTAL,S.DESCONTO,C.NOME AS CLIENTES,FU.NOME AS FUNCIONARIOS,FP.NOME AS FORMAS_PAGAMENTOS FROM SAIDAS S INNER JOIN CLIENTES C ON S.CLIENTE_ID = C.ID INNER JOIN FUNCIONARIOS FU ON S.FUNCIONARIO_ID = FU.ID INNER JOIN FORMAS_PAGAMENTO FP ON S.FORMA_PAGAMENTO_ID = FP.ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<SaidaView> saidas = new List<SaidaView>();
                while (reader.Read())
                {
                    SaidaView saida = new SaidaView();
                    saida.ID = Convert.ToInt32(reader["ID"]);
                    saida.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.Cliente = Convert.ToString(reader["CLIENTES"]);
                    saida.Funcionario = Convert.ToString(reader["FUNCIONARIOS"]);
                    saida.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saida.FormaPagamento = (FormaPagamento)reader["FORMAS_PAGAMENTOS"];
                    saida.ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"]);

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

        public async Task<SingleResponse<Saida>> GetById(int id)
        {
            string sql = $"SELECT ID,VALOR,CLIENTE_ID,FUNCIONARIO_ID,DATA_SAIDA,FORMA_PAGAMENTO_ID,DESCONTO,VALOR_TOTAL FROM SAIDAS WHERE ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Saida saida = new Saida();
                    saida.ID = Convert.ToInt32(reader["ID"]);
                    saida.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.ClienteID = Convert.ToInt32(reader["CLIENTE_ID"]);
                    saida.FuncionarioID = Convert.ToInt32(reader["FUNCIONARIO_ID"]);
                    saida.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saida.FormaPagamento = (FormaPagamento)reader["FORMA_PAGAMENTO_ID"];
                    saida.Valor_Total = Convert.ToDouble(reader["VALOR_TOTAL"]);
                    return SingleResponseFactory<Saida>.CreateInstance().CreateSuccessSingleResponse(saida);
                }
                return SingleResponseFactory<Saida>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Saida>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<SingleResponse<SaidaView>> GetSaidaViewById(int id)
        {
            string sql = $"SELECT S.ID,S.VALOR,S.DATA_SAIDA,S.VALOR_TOTAL,S.DESCONTO,C.NOME AS CLIENTES,FU.NOME AS FUNCIONARIOS,FP.NOME AS FORMAS_PAGAMENTOS FROM SAIDAS S INNER JOIN CLIENTES C ON S.CLIENTE_ID = C.ID INNER JOIN FUNCIONARIOS FU ON S.FUNCIONARIO_ID = FU.ID INNER JOIN FORMAS_PAGAMENTO FP ON S.FORMA_PAGAMENTO_ID = FP.ID WHERE S.ID = @ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    SaidaView saida = new SaidaView();
                    saida.ID = Convert.ToInt32(reader["ID"]);
                    saida.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.Cliente = Convert.ToString(reader["CLIENTES"]);
                    saida.Funcionario = Convert.ToString(reader["FUNCIONARIOS"]);
                    saida.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saida.FormaPagamento = (FormaPagamento)reader["FORMAS_PAGAMENTOS"];
                    saida.ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"]);
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
		FP.NOME 'FORMA_DE_PAGAMENTO',
		S.VALOR_TOTAL,
		S.DESCONTO
FROM    SAIDAS S
        INNER JOIN
        CLIENTES C ON S.CLIENTE_ID = C.ID

        INNER JOIN

        FUNCIONARIOS F ON S.FUNCIONARIO_ID = F.ID

        INNER JOIN

        FORMAS_PAGAMENTO FP ON S.FORMA_PAGAMENTO_ID = FP.ID WHERE 1 = 1 AND DATA_SAIDA BETWEEN @DATA_INICIAL AND @DATA_FINAL";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@DATA_INICIAL", saida.Inicio);
            command.Parameters.AddWithValue("@DATA_FINAL", saida.Fim);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<SaidaView> saidasView = new List<SaidaView>();
                while (reader.Read())
                {
                    SaidaView saidaView = new SaidaView();
                    saidaView.ID = Convert.ToInt32(reader["ID"]);
                    saidaView.Valor = Convert.ToDouble(reader["VALOR"]);
                    saidaView.Cliente = Convert.ToString(reader["CLIENTE"]);
                    saidaView.Funcionario = Convert.ToString(reader["FUNCIONARIO"]);
                    saidaView.DataSaida = Convert.ToDateTime(reader["DATA_SAIDA"]);
                    saidaView.FormaPagamento = (FormaPagamento)reader["FORMA_DE_PAGAMENTO"];
                    saidaView.ValorTotal = Convert.ToDouble(reader["VALOR_TOTAL"]);
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
