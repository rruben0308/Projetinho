using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Shorts
    {
        string shortA = "32";
        string shortB = "32";
        string shortC = "32";
        string shortD = "32";
        string shortE = "32";
        public void mostrarShorts()
        {
            Console.WriteLine("Short Azul R${0}", shortA);
            Console.WriteLine("Short Verde R${0}", shortB);
            Console.WriteLine("Short Amarelo R${0}", shortC);
            Console.WriteLine("Short Vermelha R$ {0}", shortD);
            Console.WriteLine("Short Preto R${0}", shortE);
        }
    }
}
