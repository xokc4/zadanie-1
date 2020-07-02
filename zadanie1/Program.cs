using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace ConsoleApp_var20_zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {

            int X, g, k;
            double p;
            double Sum = 0;
            Console.Write("Введите кол-во выстрелов: ");
            X = Int16.Parse(Console.ReadLine());
            Console.Write("Введите вероятность поражения мишени: ");
            p = Double.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во попаданий от: ");
            g = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во попаданий до: ");
            k = Int16.Parse(Console.ReadLine());

            double[] riskList = new double[X + 1];
            for (int i = g; i <= X && g <= X && X >= k; i++)
            {
                riskList[i] = (factorial(X) / (factorial(i) * factorial(X - i) * 1.0)) * Math.Pow((1 - p), (X - i)) * Math.Pow((p), i);
            }
            for (int i = 0; i <= X && g <= X && X >= k; ++i)
            {
                Sum += riskList[i];
            }
            for (int i = g; i <= X; ++i)
            {
                Console.WriteLine("Данные вероятности = " + Math.Round(riskList[i], 4));
            }
            Console.WriteLine("SYMMA = " + Sum);
        }
        static int factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

    }
}
