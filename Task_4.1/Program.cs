using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное число N>0");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
            {

                for (int i = 1, N2 = 0; i <= N; i++)
                {
                    N2 += i * 2 - 1;
                    Console.WriteLine("Значение N2 = {0}", N2);
                }

            }
            else
            {
                Console.WriteLine("Неверно введено значение!");
            }

            Console.ReadKey();
        }
    }
}