using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 0;
            int N = 0;
            Console.WriteLine("Введите длину и ширину пола");
            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            Console.WriteLine("Введите длину и ширину листа ламината");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int z = 0;
            int n = 0;
            z = M * N;
            n = a * b;
            int K = 0;
            K = z / n;
            Console.WriteLine("Кол-во листов ламината");
            Console.WriteLine(K);
            Console.ReadLine();
        }
    }
}
