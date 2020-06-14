using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ex._6
{
    class Program
    {
        static List<double> posl = new List<double>();
        static double AddElements (int N)
        {
            if (N == 1)
            {
                return posl[0];
            }
            if (N == 2)
            {
                return posl[1];
            }
            if (N == 3)
            {
                return posl[2];
            }
            if (N >= 4)
            {
                if (N >= posl.Count)
                {
                    posl.Add(AddElements(N - 1) + AddElements(N - 2) / 3 + 3 * AddElements(N - 3));
                }
                return AddElements(N - 1) + AddElements(N - 2) / 3 + 3 * AddElements(N - 3);
            }
            return 0;
        }

        static void Show (List<double> posl)
        {
            foreach(double n in posl)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите первый член");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй член");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третий член");
            double a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите M");
            double M = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов");
            int N = int.Parse(Console.ReadLine());
            posl.Add(a1);
            posl.Add(a2);
            posl.Add(a3);
            AddElements(N);
            Show(posl);
            int count = 0;
            foreach (double n in posl)
            {
                if (n == M)
                {
                    count++;
                }
            }
            Console.WriteLine($"В последовательности найдено {count} элементов равных {M}");
            Console.WriteLine($"Номера элементов, равных {M}:");
            for (int i = 0; i < posl.Count; i++)
            {
                if (posl[i] == M)
                {
                    Console.Write($"{i + 1} ");
                }
            }
            Console.ReadKey();
        }
    }
}
