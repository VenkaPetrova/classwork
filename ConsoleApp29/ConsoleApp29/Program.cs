using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи а,b");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Всяко х е решение на линейното уравнение");

                }
                else
                {
                    Console.WriteLine("Линейното уравнение няма решение ");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("x= " + x);
            }
            Console.ReadKey();
        }  
    }
}
