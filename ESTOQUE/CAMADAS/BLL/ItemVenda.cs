using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.BLL
{
    public class ItemVenda
    {
        public List<MODEL.ItemVenda> SelectByIDVenda(int idVenda)
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            return dalItemVenda.SelectByIDVenda(idVenda);
        }

        public List<MODEL.ItemVenda> Select()
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            return dalItemVenda.Select();
        }

        public void Insert(MODEL.ItemVenda itemVenda)
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            BLL.Produto bllProd = new Produto();
            List<MODEL.Produto> lstProd = bllProd.SelectById(itemVenda.produto);
            MODEL.Produto produto = lstProd[0];
            if (produto.quantidade >= itemVenda.quantidade)
            {
                produto.quantidade = produto.quantidade - itemVenda.quantidade;
                bllProd.Update(produto);
                dalItemVenda.Insert(itemVenda);
            }
            else Console.WriteLine("Estoque insuficiente..."); 
        }

        public void Update(MODEL.ItemVenda itemVenda)
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            dalItemVenda.Update(itemVenda);
        }

        public void Delete(int id)
        {
            DAL.ItemVenda dalItemVenda = new DAL.ItemVenda();
            dalItemVenda.Delete(id);
        }


    }
}




