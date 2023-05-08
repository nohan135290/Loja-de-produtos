using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAplication1
{
    class Configuracao
    {
        public int numero { get; set; }
        
        public Configuracao() { }

        public void Configuracao1()
        {
            Console.WriteLine("- Computador Completo Requisitos -");
            Console.WriteLine("Monitor: 49 polegadas 144hz");
            Console.WriteLine("Gabinete: Atx");
            Console.WriteLine("Placa Mãe: Z650m DDR5");
            Console.WriteLine("Processador: Ryzen 7 7800x");
            Console.WriteLine("Memoria: Corsair DDR5 6800mhz");
            Console.WriteLine("Placa de Vídeo: RTX 4070 ti");
            Console.WriteLine("Fonte: 850w plus Bronze");
            Console.WriteLine("2x SSDS nvme 2.0 1tb, nvme 2.0 250gb");
            Console.WriteLine("teclado: Mecânico com rgb");
            Console.WriteLine("Mouse Pad: 100x200x");
            Console.WriteLine("Mouse: 8000pi rgb");
            Console.WriteLine("");

            Console.Write("Você deseja completar essa compra?  ");
            char compra = char.Parse(Console.ReadLine());
            if (compra == 's' || compra == 'S')
            {
                Console.WriteLine("Compra efetuada com sucesso! ");
                Console.WriteLine("Agradeçemos a sua compra volte sempre! :)");
            }
            else
            {
                Console.WriteLine("Compra não efetuada com sucesso!  ");
                Console.WriteLine();                
            }
        }

        public void Configuracao2()
        {
            Console.WriteLine("- Notebook Requisitor -");
            Console.WriteLine("Memória Ram: 16gb (2x8) 6800mhz DDR5");
            Console.WriteLine("Processador: i7 11800H");
            Console.WriteLine("SSD: nvme 2.0 512gb");
            Console.WriteLine("SO: Windows 11 Pro");
            Console.WriteLine("Placa Gráfica: RTX 3070 4gb");
            Console.WriteLine(" ");

            Console.Write("Você deseja completar essa compra? ");
            char compra = char.Parse(Console.ReadLine());
            if (compra == 's' || compra == 'S')
            {
                Console.WriteLine("Compra efetuada com sucesso! ");
                Console.WriteLine("Agradeçemos a sua compra volte sempre! :)");
            }
            else
            {
                Console.WriteLine("Compra não efetuada com sucesso! ");
                Console.WriteLine("");                
            }
        }

        public void Configuracao3()
        {
            Console.WriteLine(" - Celular Asus Rog Phone 5 - ");
            Console.WriteLine("Placa Gráfica: SnapDragon 888");
            Console.WriteLine("Memória ram: 12gb");
            Console.WriteLine("Memória Interna: 256gb");
            Console.WriteLine("Duração Báteria: 6.000 mAh");
            Console.WriteLine("Câmera Frontal: 50mg pixel");
            Console.WriteLine("Câmera Traseira: 50mg pixel");
            Console.WriteLine("Dimensão da tela: 1080x2448 Pixels");
            Console.WriteLine("frequencia tela: 144mhz");
            Console.WriteLine(" ");

            Console.Write("Você deseja completar essa compra? ");
            char compra = char.Parse(Console.ReadLine());
            if (compra == 's' || compra == 'S')
            {
                Console.WriteLine("Compra efetuada com sucesso! ");
                Console.WriteLine("Agradeçemos a sua compra volte sempre! :)");
            }
            else
            {
                Console.WriteLine("Compra não efetuada com sucesso! ");
                Console.WriteLine(" ");               
            }
        }
    }
}
