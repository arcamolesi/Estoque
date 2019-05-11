using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Cliente> Select()
        {
            List<MODEL.Cliente> lstCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.id = Convert.ToInt32(dados["id"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.aniversario = Convert.ToDateTime(dados["aniversario"].ToString());
                    cliente.telefone = dados["telefone"].ToString();
                    lstCliente.Add(cliente);

                }
            }
            catch
            {
                Console.WriteLine("Consulta Select de Clientes deu problema");
            }
            finally
            {
                conexao.Close(); //não é necessario pois usou o CommandBehavior.CloseConnection
            }
            return lstCliente;
        }

        public void Insert(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Clientes values(@nome, @aniversario, @telefone)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@aniversario", cliente.aniversario);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de Clientes...");      
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Clientes set nome=@nome, aniversario=@aniversario, telefone=@telefone where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@aniversario", cliente.aniversario);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro de Atualização de Clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int id)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Clientes where id=@id";
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
