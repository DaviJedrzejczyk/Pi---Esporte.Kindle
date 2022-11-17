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
    public class ProdutoEntradaDAL : IProdutoEntradaDALService
    {
        private string connectionString = ConnectionString._connectionString;
        public DataResponse<ProdutoEntradaView> GetAllByEntradaID(int id)
        {
            string sql = $"SELECT PE.ENTRADA_ID,PE.QUANTIDADE,PE.VALOR_UNITARIO,P.NOME AS PRODUTO,P.DESCRICAO,P.VALOR,L.NOME AS LABORATORIOS,TU.NOME AS TIPOS_UNIDADES FROM PRODUTOS_ENTRADAS PE INNER JOIN PRODUTOS P ON PE.PRODUTO_ID = P.ID INNER JOIN LABORATORIOS L ON P.LABORATORIO_ID = L.ID INNER JOIN TIPOS_UNIDADES TU ON P.TIPO_UNIDADE_ID = TU.ID WHERE PE.ENTRADA_ID = @ENTRADA_ID";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ENTRADA_ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<ProdutoEntradaView> produtosEntradas = new List<ProdutoEntradaView>();
                while (reader.Read())
                {
                    ProdutoEntradaView entrada = new ProdutoEntradaView();
                    ProdutoView produtoView = new ProdutoView();
                    entrada.Produto = produtoView;
                    entrada.EntradaID = Convert.ToInt32(reader["ENTRADA_ID"]);
                    entrada.ValorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]);
                    entrada.Produto.Descricao = Convert.ToString(reader["DESCRICAO"]);
                    entrada.Produto.Valor = Convert.ToDouble(reader["VALOR"]);
                    entrada.Quantidade = Convert.ToDouble(reader["QUANTIDADE"]);
                    entrada.Produto.Nome = Convert.ToString(reader["PRODUTO"]);
                    produtosEntradas.Add(entrada);
                }
                return DataResponseFactory<ProdutoEntradaView>.CreateInstance().CreateSuccessResponse(produtosEntradas);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<ProdutoEntradaView>.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }

        }

        public async Task<Response> Insert(ProdutoEntrada produtosEntrada)
        {
            string sql = $"INSERT INTO PRODUTOS_ENTRADAS (ENTRADA_ID,PRODUTO_ID,QUANTIDADE,VALOR_UNITARIO) VALUES (@ENTRADA_ID,@PRODUTO_ID,@QUANTIDADE,@VALOR_UNITARIO) ";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ENTRADA_ID", produtosEntrada.EntradaID);
            command.Parameters.AddWithValue("@PRODUTO_ID", produtosEntrada.ProdutoId);
            command.Parameters.AddWithValue("@QUANTIDADE", produtosEntrada.Quantidade);
            command.Parameters.AddWithValue("@VALOR_UNITARIO", produtosEntrada.ValorUnitario);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
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
    }
}
