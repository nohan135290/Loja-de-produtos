using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAplication1
{
    class Program
    {
        static void Main( string [] args )
        {
            Configuracao conf = new Configuracao();

            Console.WriteLine("Escolha um item da loja.");
            Console.WriteLine(" ");
            Console.WriteLine("----- Tabela de Preços -----");
            Console.WriteLine($"{1}: Computador Completo - R$ 14.900");
            Console.WriteLine($"{2}: Notebook Gamer - R$8.000");
            Console.WriteLine($"{3}: Celular Asus Rog Phone - R$ 5.000");
            Console.WriteLine(" ");

            Console.Write("Digite um número da sua compra! ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0 && numero < 2)
            {
                conf.Configuracao1();
            }
            else
            {
                Console.WriteLine();
            }

            if (numero > 1 && numero < 3)
            {
                conf.Configuracao2();
            }
            else
            {
                Console.WriteLine();
            }

            if (numero > 2 && numero < 4)
            {
                conf.Configuracao3();
            }
            else
            {
                Console.WriteLine();
            }


        }
    }
}
