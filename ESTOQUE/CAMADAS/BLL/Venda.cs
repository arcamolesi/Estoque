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
        
        public void Insert (MODEL.Venda venda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            dalVenda.Insert(venda); 
        }

        public void Update (MODEL.Venda venda)
        {
            DAL.Venda dalVenda = new DAL.Venda();
            dalVenda.Update(venda);
        }

        public void Delete (int id)
        {
            DAL.Venda dalProd = new DAL.Venda();
            dalProd.Delete(id); 
        }
       
        
    }
}




