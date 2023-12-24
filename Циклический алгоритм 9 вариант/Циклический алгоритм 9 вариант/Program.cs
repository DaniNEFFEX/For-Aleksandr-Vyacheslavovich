using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Циклический_алгоритм_9_вариант
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n = ");
            int n = int.Parse(Console.ReadLine());
            double S = 111 , A = 5;
            for (int k = 1; k <= n - 1;k++)
            {
                S = S *(Math.Sqrt(A * ((k + 1) / k)) / Math.Sqrt(Math.Pow(7,k)));
            }
            Console.WriteLine();
            Console.WriteLine($"S={S}");
        }
    }
}
