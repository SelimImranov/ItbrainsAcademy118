using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend118_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] backend118 = { "Selim", "Nicat.H", "Metanet" };
            //Console.WriteLine(backend118);
            //foreach (var item in backend118) 
            //{
            //    Console.WriteLine(item);

            //} 
            //for (int i = 0; i < backend118.Length; i++)
            //{
            //    Console.WriteLine(backend118[i]);
            //}
            //int count = 0;
            //foreach (var item in backend118)
            //{
            //    if (item == "eli")
            //    {
            //        count++;
            //        Console.WriteLine("var");
            //    }
            //    if (count == 0)
            //    {
            //        Console.WriteLine("yoix");
            //    }
            //}
            Console.WriteLine("1ci eded");
            float x1 = (float)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2 ci eded");
            float x2 = (float)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("symbol daxil et");
            string symbol = Console.ReadLine();

            //if (symbol == "+")
            //{
            //    Console.WriteLine(x1 + x2);
            //}
            //if(symbol== "-")
            //{
            //    Console.WriteLine(x1-x2);
            //}
            //if (symbol == "/")
            //{
            //    Console.WriteLine(x1 / x2);
            //}
            //if (symbol == "*")
            //{
            //    Console.WriteLine(x1 * x2);
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun simbol daxil edilmeyib");
            //}
            switch (symbol) {
                case "+":
                    Console.WriteLine("Result :" + x1+x2);
                    break;
                case "-":
                    Console.WriteLine("Result :" + (x1 - x2));
                    break;
                case "*":
                    Console.WriteLine("Result :" + x1 * x2);
                    break;
                case "/":
                    Console.WriteLine("Result :" + x1 / x2);
                    break;
                default:
                    Console.WriteLine("Duzgun simbol daxil edilmeyib");
                    break;
            }
        }
    }
}