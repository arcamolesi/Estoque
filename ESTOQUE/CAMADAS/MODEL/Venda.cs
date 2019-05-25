using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.MODEL
{
    public class Venda
    {
        public int id { get; set; }
        public int cliente { get; set; }
        public virtual string nome { get; set; }
        public DateTime data { get; set; }
    }
}
