using DataAccessLayer.Interfaces;
using Entities;
using Shared;
using Shared.Factory;
using System.Data.SqlClient;

namespace DataAccessLayer.Implements
{
    public class ProdutosSaidaDAL : IProdutoSaidaDALService
    {

        private string connectionString = ConnectionString._connectionString;
        public async Task<DataResponse<ProdutoSaidaView>> GetAllBySaidaID(int id)
        {
            string sql = $"SELECT PS.SAIDA_ID,PS.QUANTIDADE,PS.VALOR_UNITARIO,P.NOME AS PRODUTO,P.DESCRICAO,P.VALOR FROM PRODUTOS_SAIDA PS INNER JOIN PRODUTOS P ON PS.PRODUTOS_ID = P.ID WHERE PS.SAIDA_ID = @SAIDA_ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@SAIDA_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ProdutoSaidaView> produtoSaidas = new();
                while (reader.Read())
                {
                
                    ProdutoView produtoView = new();
                    ProdutoSaidaView saida = new();
                    saida.ProdutoView = produtoView;
                    saida.SaidaID = Convert.ToInt32(reader["SAIDA_ID"]);
                    saida.ValorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
                    saida.ProdutoView.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    saida.ProdutoView.Valor = Convert.ToDouble(reader["VALOR"]);
                    saida.Quantidade = Convert.ToDouble(reader["QUANTIDADE"]);
                    saida.ProdutoView.Nome = Convert.ToString(reader["PRODUTO"]);
                    produtoSaidas.Add(saida);
                }
                return DataResponseFactory<ProdutoSaidaView>.CreateInstance().CreateSuccessResponse(produtoSaidas);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<ProdutoSaidaView>.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<Response> Insert(ProdutoSaida produto)
        {
            string sql = $"INSERT INTO PRODUTOS_SAIDA (SAIDA_ID,PRODUTOS_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@SAIDA_ID,@PRODUTOS_ID,@QUANTIDADE,@VALOR_UNITARIO)";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@PRODUTOS_ID", produto.ProdutoId);
            command.Parameters.AddWithValue("@SAIDA_ID", produto.SaidaId);
            command.Parameters.AddWithValue("@QUANTIDADE", produto.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", produto.ValorUnitario);
            try
            {
                await connection.OpenAsync();
                command.ExecuteNonQuery();
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailureResponse();
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
