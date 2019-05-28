using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.DAL
{
    public class ItemVenda
    {
        private string strCon = Conexao.getConexao();
        
        
        public List<MODEL.ItemVenda> SelectByIDVenda(int idVenda)
        {
            List<MODEL.ItemVenda> lstVenda = new List<MODEL.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select ItemVenda.id, ItemVenda.venda, ItemVenda.produto, " +
                " Produtos.descricao, ItemVenda.quantidade, ItemVenda.valor from " +
                " ItemVenda inner join Produtos on ItemVenda.produto=Produtos.id " +
                " where ItemVenda.venda = @idVenda"; 
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idVenda", idVenda);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.ItemVenda itemVenda = new MODEL.ItemVenda();
                    itemVenda.id = Convert.ToInt32(dados["id"].ToString());
                    itemVenda.venda = Convert.ToInt32(dados["venda"].ToString());
                    itemVenda.produto = Convert.ToInt32(dados["produto"].ToString());
                    itemVenda.descricao = dados["descricao"].ToString();
                    itemVenda.quantidade = Convert.ToSingle(dados["quantidade"].ToString());
                    itemVenda.valor = Convert.ToSingle(dados["valor"].ToString());
                    lstVenda.Add(itemVenda);

                }
            }
            catch
            {
                Console.WriteLine("Consulta Select de Vendas deu problema");
            }
            finally
            {
                conexao.Close(); //não é necessario pois usou o CommandBehavior.CloseConnection
            }
            return lstVenda;
        }
        public List<MODEL.ItemVenda> Select()
        {
            List<MODEL.ItemVenda> lstVenda = new List<MODEL.ItemVenda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select ItemVenda.id, ItemVenda.venda, ItemVenda.produto, " +
                " Produtos.descricao, ItemVenda.quantidade, ItemVenda.valor from " +
                " ItemVenda inner join Produtos on ItemVenda.produto=Produtos.id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.ItemVenda itemVenda = new MODEL.ItemVenda();
                    itemVenda.id = Convert.ToInt32(dados["id"].ToString());
                    itemVenda.venda = Convert.ToInt32(dados["venda"].ToString());
                    itemVenda.produto = Convert.ToInt32(dados["produto"].ToString());
                    itemVenda.descricao = dados["descricao"].ToString();
                    itemVenda.quantidade = Convert.ToSingle(dados["quantidade"].ToString());
                    itemVenda.valor = Convert.ToSingle(dados["valor"].ToString());
                    lstVenda.Add(itemVenda);

                }
            }
            catch
            {
                Console.WriteLine("Consulta Select de Vendas deu problema");
            }
            finally
            {
                conexao.Close(); //não é necessario pois usou o CommandBehavior.CloseConnection
            }
            return lstVenda;
        }

        public void Insert(MODEL.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into ItemVenda values(@venda, @produto, "+
                         " @quantidade, @valor)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@venda", itemVenda.venda);
            cmd.Parameters.AddWithValue("@produto", itemVenda.produto);
            cmd.Parameters.AddWithValue("@quantidade", itemVenda.quantidade);
            cmd.Parameters.AddWithValue("@valor", itemVenda.valor);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de ItemVenda...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.ItemVenda itemVenda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update ItemVenda set venda=@venda, produto=@produto, " +
                         " quantidade=@quantidade, valor=@valor where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", itemVenda.id);
            cmd.Parameters.AddWithValue("@venda", itemVenda.venda);
            cmd.Parameters.AddWithValue("@produto", itemVenda.produto);
            cmd.Parameters.AddWithValue("@quantidade", itemVenda.quantidade);
            cmd.Parameters.AddWithValue("@valor", itemVenda.valor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro de Atualização de ItemVenda...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from ItemVenda where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remoção...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
