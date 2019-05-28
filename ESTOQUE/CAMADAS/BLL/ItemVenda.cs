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
            dalItemVenda.Insert(itemVenda);
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




