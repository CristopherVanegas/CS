using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(Environment.TickCount);
            Console.CursorVisible = false;
            int moviT;
            int moviL;
            int posXT = 10;
            int posXL = 10;
            for (int i = 0; i < 100; i++)
            {
                moviT = random.Next(0, 4); //no incluye el 4 
                moviL = random.Next(0, 4); //no incluye el 4 
                if (moviT == 0)
                {
                    Thread.Sleep(100);
                    Console.SetCursorPosition(posXT, 10);
                    Console.WriteLine(" ");
                    posXT = posXT + 1;
                    Console.SetCursorPosition(posXT, 10);
                    Console.WriteLine("T");
                }
                if (moviT == 1)
                {
                    Thread.Sleep(100);
                    Console.SetCursorPosition(posXT, 10);
                    Console.WriteLine(" ");
                    posXT = posXT + 2;
                    Console.SetCursorPosition(posXT, 10);
                    Console.WriteLine("T");
                }
                if (moviT == 2)
                {
                    Thread.Sleep(100);
                    Console.SetCursorPosition(posXT, 10);
                    Console.WriteLine(" ");
                    posXT = posXT - 1;
                    Console.SetCursorPosition(posXT, 10);
                    Console.WriteLine("T");
                }

                if (moviL == 0)
                {
                    Thread.Sleep(100);
                    Console.SetCursorPosition(posXL, 20);
                    Console.WriteLine(" ");
                    posXL = posXL + 1;
                    Console.SetCursorPosition(posXL, 20);
                    Console.WriteLine("L");
                }
                if (moviL == 1)
                {
                    Thread.Sleep(100);
                    Console.SetCursorPosition(posXL, 20);
                    Console.WriteLine(" ");
                    posXL = posXL + 2;
                    Console.SetCursorPosition(posXL, 20);
                    Console.WriteLine("L");
                }
                if (moviL == 2)
                {
                    Thread.Sleep(100);
                    Console.SetCursorPosition(posXL, 20);
                    Console.WriteLine(" ");
                    posXL = posXL - 1;
                    Console.SetCursorPosition(posXL, 20);
                    Console.WriteLine("L");
                }
            }

            Console.ReadKey();


        }


    }
}