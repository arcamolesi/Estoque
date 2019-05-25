using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.DAL
{
    public class Venda
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Venda> Select()
        {
            List<MODEL.Venda> lstVenda = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select Vendas.id, Vendas.cliente, Clientes.nome, Vendas.data from Vendas "; 
                sql += " inner join Clientes on Vendas.cliente=Clientes.id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Venda venda = new MODEL.Venda();
                    venda.id = Convert.ToInt32(dados["id"].ToString());
                    venda.cliente = Convert.ToInt32(dados["cliente"].ToString());
                    venda.nome = dados["nome"].ToString(); 
                    venda.data = Convert.ToDateTime(dados["data"].ToString());
                   
                    lstVenda.Add(venda);

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

        public void Insert(MODEL.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Vendas values( @data, @cliente)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cliente", venda.cliente);
            cmd.Parameters.AddWithValue("@data", venda.data);
           try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Vendas...");      
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Venda venda)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Vendas set cliente=@cliente, data=@data where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", venda.id);
            cmd.Parameters.AddWithValue("@cliente", venda.cliente);
            cmd.Parameters.AddWithValue("@data", venda.data);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro de Atualização de Vendas...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Vendas where id=@id";
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
