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
    public class ProdutoDAL : IProdutoDALService
    {
        private string connectionString = ConnectionString._connectionString;

        public async Task<Response> Insert(Produto produto)
        {
            string sql = $"INSERT INTO PRODUTOS (NOME,DESCRICAO,QTD_ESTOQUE,VALOR,FORNECEDOR_ID,CATEGORIA_ID) VALUES (@NOME,@DESCRICAO,@QTD_ESTOQUE,@VALOR,@FORNECEDOR_ID,@CATEGORIA_ID)";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@NOME", produto.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QtdEstoque);
            command.Parameters.AddWithValue("@VALOR", produto.Valor_Unitario);
            command.Parameters.AddWithValue("@FORNECEDOR_ID", produto.Fornecedor.ID);
            command.Parameters.AddWithValue("@CATEGORIA_ID", produto.Categoria.ID);
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

        public async Task<Response> Update(Produto produto)
        {
            string sql = $"UPDATE PRODUTOS SET NOME = @NOME, DESCRICAO = @DESCRICAO, QTD_ESTOQUE = @QTD_ESTOQUE, VALOR = @VALOR, FORNECEDOR_ID = @FORNECEDOR_ID, CATEGORIA_ID = @CATEGORIA_ID WHERE ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@NOME", produto.Nome);
            command.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QtdEstoque);
            command.Parameters.AddWithValue("@VALOR", produto.Valor_Unitario);
            command.Parameters.AddWithValue("@FORNECEDOR_ID", produto.Fornecedor.ID);
            command.Parameters.AddWithValue("@CATEGORIA_ID", produto.Categoria.ID);
            command.Parameters.AddWithValue("@ID", produto.ID);
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
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }
        public async Task<Response> Delete(int id)
        {
            string sql = "DELETE FROM PRODUTOS WHERE ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
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
                if (ex.Message.Contains("FK_PRODUTOS_SAIDA_PRODUTOS"))
                {
                    return ResponseFactory.CreateInstance().CreateFailureResponse();
                }
                if (ex.Message.Contains("FK_PRODUTOS_ENTRADAS_PRODUTOS"))
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

        public async Task<DataResponse<Produto>> GetAll()
        {
            string sql = $"SELECT ID,NOME,DESCRICAO,QTD_ESTOQUE,VALOR,FORNECEDOR_ID,CATEGORIA_ID FROM PRODUTOS";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<Produto> produtos = new();
                while (reader.Read())
                {
                    Produto produto = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nome = Convert.ToString(reader["NOME"]),
                        Descricao = Convert.ToString(reader["DESCRICAO"]),
                        QtdEstoque = Convert.ToInt32(reader["QTD_ESTOQUE"]),
                        Valor_Unitario = Convert.ToDouble(reader["VALOR"]),
                        FornecedorId = Convert.ToInt32(reader["FORNECEDOR_ID"]),
                        CategoriaId = Convert.ToInt32(reader["CATEGORIA_ID"])
                    };

                    produtos.Add(produto);
                }
                return DataResponseFactory<Produto>.CreateInstance().CreateSuccessResponse(produtos);
            }
            catch (Exception ex)
            {
                return DataResponseFactory<Produto>.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<SingleResponse<Produto>> GetById(int id)
        {
            string sql = $"SELECT ID,NOME,DESCRICAO,QTD_ESTOQUE,VALOR,FORNECEDOR_ID,CATEGORIA_ID FROM PRODUTOS WHERE ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@ID", id);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Produto produto = new()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nome = Convert.ToString(reader["NOME"]),
                        Descricao = Convert.ToString(reader["DESCRICAO"]),
                        QtdEstoque = Convert.ToInt32(reader["QTD_ESTOQUE"]),
                        Valor_Unitario = Convert.ToDouble(reader["VALOR"]),
                        FornecedorId = Convert.ToInt32(reader["FORNECEDOR_ID"]),
                        CategoriaId = Convert.ToInt32(reader["CATEGORIA_ID"])
                        
                    };

                    return SingleResponseFactory<Produto>.CreateInstance().CreateSuccessSingleResponse(produto);
                }
                return SingleResponseFactory<Produto>.CreateInstance().CreateFailureSingleResponse();
            }
            catch (Exception ex)
            {
                return SingleResponseFactory<Produto>.CreateInstance().CreateFailureSingleResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }

        public async Task<Response> UpdateValueAndInventory(Produto produto)
        {
            string sql = $"UPDATE PRODUTOS SET VALOR = @VALOR, QTD_ESTOQUE = @QTD_ESTOQUE WHERE ID = @ID";
            SqlConnection connection = new(connectionString);
            SqlCommand command = new(sql, connection);
            command.Parameters.AddWithValue("@VALOR", produto.Valor_Unitario);
            command.Parameters.AddWithValue("@QTD_ESTOQUE", produto.QtdEstoque);
            command.Parameters.AddWithValue("@ID", produto.ID);
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
                return ResponseFactory.CreateInstance().CreateFailureResponse(ex);
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}
