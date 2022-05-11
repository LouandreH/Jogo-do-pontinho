using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cenario
    {
        public String Chao { get; set; }
        public Byte Tamanho { get; set; }

        public Cenario(string chao, byte tamanho)
        {
            this.Chao = chao;
            this.Tamanho = tamanho;
        }

        public void imprime(Player p)
        {
            Console.Clear();
            Console.WriteLine();

            if (p.Pulando)
            {
                for (byte i = 0; i <p.Posicao; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(p.Aparencia);

            }
            else
            {
                Console.WriteLine();

            }
            //imprimi segunda linha
            for (Byte i = 0; i < p.Posicao; i++)
            {
                Console.Write(Chao);
            }
            if (p.Pulando) Console.Write(Chao);
            else Console.Write(p.Aparencia);

            for (Byte i = 0; i < (Tamanho - p.Posicao) ;i++)
            {
                Console.Write(Chao);
            }
        }
    }
}
