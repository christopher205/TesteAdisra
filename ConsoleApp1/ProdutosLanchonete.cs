using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProdutosLanchonete
    {
        public int LancheCarne { get; set; }
        public int LancheFrango { get; set; }
        public int Batafrita { get; set; }
        public int Refrigerante { get; set; }
        public int Salada { get; set; }
        public int Maionese { get; set; }


        public int CalculaValorLanche(ProdutosLanchonete valorLanche)
        {
           return LancheCarne + LancheFrango + Batafrita + Refrigerante + Salada + Maionese;
        }
    }
}
