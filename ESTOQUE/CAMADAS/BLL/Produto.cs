using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.BLL
{
    public class Produto
    {
        public List<MODEL.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.Select(); 
        }
        
        public void Insert (MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (produto.descricao != "")
                dalProd.Insert(produto); 
        }

        public void Update (MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (produto.descricao != string.Empty)
                dalProd.Update(produto);
        }

        public void Delete (int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (id > 0)
                dalProd.Delete(id); 
        }
       
        
    }
}




