using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.Relatorios
{
    public class relProdutos
    {

        public static void relGeralProdutos()
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            List<CAMADAS.MODEL.Produto> lstProdutos = new List<CAMADAS.MODEL.Produto>();


            lstProdutos = bllProd.Select();


            string folder = Funcoes.diretorioPasta(); 

            string arquivo = folder + @"\RelProduto.html";

            //IMPRIMIR O RELATÓRIO - GERAR O HTML
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<HTML>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html'; " +
                             "charset='utf-8'>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css' integrity='sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO' crossorigin='anonymous'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatorio de Produtos</h1>");
                sw.WriteLine("<hr align=left border: '5px'>");
                sw.WriteLine("<table class='table table - hover'>");
                sw.WriteLine("<tr class='thead-dark'>");
                sw.WriteLine("<th align='right' width='30px'>ID</th>");
                sw.WriteLine("<th align='left' width='150px'>Descricao</th>");
                sw.WriteLine("<th align='right' width='90px'>Quantidade</th>");
                sw.WriteLine("<th align='right' width='80px'>Valor</th>");
                sw.WriteLine("<th align='right' width='80px'>Total</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                float totalGeral = 0;  
                float total; 
                foreach (CAMADAS.MODEL.Produto produto in lstProdutos.Where(p=>p.quantidade<15).OrderByDescending(p=>p.total).ToList()) {
                    if (cont%2==0)
                     sw.WriteLine("<tr class='table-success'>");
                    else sw.WriteLine("<tr class='table-warning'>");

                    sw.WriteLine("<td align='right' width='30px'>" + produto.id + "</th>");
                    sw.WriteLine("<td align='left' width='150px'>" + produto.descricao + "</th>");
                    sw.WriteLine("<td align='right' width='90px'>" + produto.quantidade + "</th>");
                    sw.WriteLine("<td align='right' width='80px'>" + string.Format("{0:#.#,0}", produto.valor) + "</th>");
                   // total = produto.quantidade * produto.valor;
                    totalGeral += produto.total; 
                    sw.WriteLine("<td align='right' width='80px'>" + string.Format("{0:C2}", produto.total) + "</th>");
                    sw.WriteLine("</tr>");
                    cont++; 
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align=left border: '5px'>");
                sw.WriteLine("<h2>Total Geral: " + string.Format("{0:C2}",totalGeral) + "</h2>");
                sw.WriteLine("<h2>Quantidade de Registros impressos: " + cont.ToString() + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</HTML>");
            }

            System.Diagnostics.Process.Start(arquivo);
        }



        public static void relGeralProdutos(int qtde, int order)
        {
            CAMADAS.BLL.Produto bllProd = new CAMADAS.BLL.Produto();
            List<CAMADAS.MODEL.Produto> lstProdutos = new List<CAMADAS.MODEL.Produto>();


            lstProdutos = bllProd.Select().Where(p =>p.quantidade<=qtde).ToList();
            
            if (order == 1)
                lstProdutos = lstProdutos.OrderBy(p => p.descricao).ToList();
            else lstProdutos = lstProdutos.OrderBy(p => p.total).ToList();


            string folder = Funcoes.diretorioPasta();

            string arquivo = folder + @"\RelProduto.html";

            //IMPRIMIR O RELATÓRIO - GERAR O HTML
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<HTML>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' content='text/html'; " +
                             "charset='utf-8'>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css' integrity='sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO' crossorigin='anonymous'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatorio de Produtos</h1>");
                sw.WriteLine("<hr align=left border: '5px'>");
                sw.WriteLine("<table class='table table - hover'>");
                sw.WriteLine("<tr class='thead-dark'>");
                sw.WriteLine("<th align='right' width='30px'>ID</th>");
                sw.WriteLine("<th align='left' width='150px'>Descricao</th>");
                sw.WriteLine("<th align='right' width='90px'>Quantidade</th>");
                sw.WriteLine("<th align='right' width='80px'>Valor</th>");
                sw.WriteLine("<th align='right' width='80px'>Total</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                float totalGeral = 0;
                float total;
                foreach (CAMADAS.MODEL.Produto produto in  lstProdutos)
                {
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-success'>");
                    else sw.WriteLine("<tr class='table-warning'>");

                    sw.WriteLine("<td align='right' width='30px'>" + produto.id + "</th>");
                    sw.WriteLine("<td align='left' width='150px'>" + produto.descricao + "</th>");
                    sw.WriteLine("<td align='right' width='90px'>" + produto.quantidade + "</th>");
                    sw.WriteLine("<td align='right' width='80px'>" + string.Format("{0:#.#,0}", produto.valor) + "</th>");
                    // total = produto.quantidade * produto.valor;
                    totalGeral += produto.total;
                    sw.WriteLine("<td align='right' width='80px'>" + string.Format("{0:C2}", produto.total) + "</th>");
                    sw.WriteLine("</tr>");
                    cont++;
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<hr align=left border: '5px'>");
                sw.WriteLine("<h2>Total Geral: " + string.Format("{0:C2}", totalGeral) + "</h2>");
                sw.WriteLine("<h2>Quantidade de Registros impressos: " + cont.ToString() + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</HTML>");
            }

            System.Diagnostics.Process.Start(arquivo);
        }

    }
}
