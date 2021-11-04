using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Camisetas
    {
        string vermelha = "50";
        string estampa = "60";
        string verde = "50";
        string amarelo = "50";
        string azul = "50";
        public void mostrarCamisetas()
        {
            Console.WriteLine("Camisa Azul R${0}", azul);
            Console.WriteLine("Camisa Verde R${0}", verde);
            Console.WriteLine("Camisa Amarelo R${0}", amarelo);
            Console.WriteLine("Camisa Vermelha R${0}", vermelha);
            Console.WriteLine("Camisa estampada R${0}", estampa);
        }
    }
}
