using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Menu
    {
        public string menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Camisas");
            Console.WriteLine("2 - Camisetas");
            Console.WriteLine("3 - Calças");
            Console.WriteLine("4 - Ternos");
            Console.WriteLine("5 - Shorts");
            Console.WriteLine("Q - Sair");
            Console.WriteLine("Escolha uma opção");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();
        }
    }
}
