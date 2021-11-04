using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Ternos
    {
        string ternoA = "950";
        string ternoB = "950";
        string ternoC = "950";
        string ternoD = "950";
        string ternoE = "950";
        public void mostrarTernos()
        {
            Console.WriteLine("Terno Azul R$ {0}", ternoA);
            Console.WriteLine("Terno Verde R$ {0}", ternoB);
            Console.WriteLine("Terno Amarelo R$ {0}", ternoC);
            Console.WriteLine("Terno Vermelho R$ {0}", ternoD);
            Console.WriteLine("Terno Preto R${0}", ternoE);
        }
    }
}
