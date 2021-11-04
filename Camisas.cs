using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Camisas
    {
        string camisa1 = "30";
        string camisa2 = "30";
        string camisa3 = "40";
        string camisa4 = "25";
        string camisa5 = "45";

        public void mostrarCamisas()
        {
            Console.WriteLine("Camisa Azul R$", camisa1);
            Console.WriteLine("Camisa Preta R${0}", camisa2);
            Console.WriteLine("Camisa Verde e Amarelo R${0}", camisa3);
            Console.WriteLine("Camisa Vermelha R${0}", camisa4);
            Console.WriteLine("Camisa estampada R${0}", camisa5);
        }
    }
}
