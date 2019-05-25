using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.BLL
{
    public class Venda
    {
        public List<MODEL.Venda> Select()
        {
            DAL.Venda dalVenda = new DAL.Venda();
            return dalVenda.Select(); 
        }
        
        public void Insert (MODEL.Venda produto)
        {
            DAL.Venda dalProd = new DAL.Venda();
           dalProd.Insert(produto); 
        }

        public void Update (MODEL.Venda produto)
        {
            DAL.Venda dalProd = new DAL.Venda();
            dalProd.Update(produto);
        }

        public void Delete (int id)
        {
            DAL.Venda dalProd = new DAL.Venda();
            dalProd.Delete(id); 
        }
       
        
    }
}




