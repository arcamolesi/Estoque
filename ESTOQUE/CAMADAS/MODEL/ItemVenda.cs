using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.MODEL
{
    public class ItemVenda
    {
        public int id { get; set; }
        public int venda { get; set; }
        public int produto { get; set; }
        public virtual string descricao { get; set; }
        public float quantidade { get; set; }
        public float valor { get; set; }

    }
}
