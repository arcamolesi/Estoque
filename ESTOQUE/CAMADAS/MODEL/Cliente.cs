using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE.CAMADAS.MODEL
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime aniversario { get; set; }
        public string telefone { get; set; }
    }
}
