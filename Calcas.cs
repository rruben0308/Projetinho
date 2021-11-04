using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Calcas
    {
        string calcaA = "100";
        string calcaB = "100";
        string calcaC = "100";
        string calcaD = "100";
        string calcaE ="100";
        public void mostrarcalcas()
        {
            Console.WriteLine("Calça Azul R${0}", calcaA);
            Console.WriteLine("Calça Verde R${0}", calcaB);
            Console.WriteLine("Calça Amarelo R${0}", calcaC);
            Console.WriteLine("Calça Vermelho R${0}", calcaD);
            Console.WriteLine("Calça Preto R${0}", calcaE);
        }
    }
}
