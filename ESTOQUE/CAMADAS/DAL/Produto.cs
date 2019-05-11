using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Produto> Select()
        {
            List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produtos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.id = Convert.ToInt32(dados["id"].ToString());
                    produto.descricao = dados["descricao"].ToString();
                    produto.quantidade = Convert.ToSingle(dados["quantidade"].ToString());
                    produto.valor = Convert.ToSingle(dados["valor"].ToString());
                    lstProdutos.Add(produto);

                }
            }
            catch
            {
                Console.WriteLine("Consulta Select de Produtos deu problema");
            }
            finally
            {
                conexao.Close(); //não é necessario pois usou o CommandBehavior.CloseConnection
            }
            return lstProdutos;
        }

        public void Insert(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Produtos values(@descricao, @quantidade, @valor)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Produtos...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produtos set descricao=@descricao, quantidade=@quantidade, valor=@valor where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro de Atualização de Produtos...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
