﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("D", "B");
            Cenario c = new Cenario("_", 100);
            ConsoleKey tecla;

            c.imprime(p);

            do
            {
                tecla = Console.ReadKey().Key;


                switch (tecla)
                {
                    case ConsoleKey.LeftArrow:
                        p.anda(false, c.Tamanho);
                        c.imprime(p);
                        break;

                    case ConsoleKey.RightArrow:
                        p.anda(true, c.Tamanho);
                        c.imprime(p);
                        break;

                    case ConsoleKey.UpArrow:
                        p.Pulando = true;
                        c.imprime(p);
                        p.pula();
                        p.Pulando = false;
                        c.imprime(p);
                        break;
                    default:
                        c.imprime(p);
                        break;

                }
                

            } while (tecla != ConsoleKey.Escape);



        }
    }
            
}
