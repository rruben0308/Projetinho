using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Menu m = new Menu();
            Camisas c = new Camisas();
            Camisetas cs = new Camisetas();
            Ternos t = new Ternos();
            Shorts s = new Shorts();
            Calcas cl = new Calcas();

            do
            {
                opcao = m.menu();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Camisa");
                        c.mostrarCamisas();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Camiseta");
                        cs.mostrarCamisetas();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Calça Jeans");
                        cl.mostrarcalcas();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ternos");
                        t.mostrarTernos();
                        break;
                    case "5":
                        Console.WriteLine("Shorts");
                        s.mostrarShorts();
                        Console.ReadKey();
                        break;
                    case "Q":
                        Console.WriteLine("Saindo");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
            } while (opcao != "Q");
        }
    }
}
