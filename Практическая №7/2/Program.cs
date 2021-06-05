using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину массива b");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-20,20);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            
            for (int i = 0; i < n; i++)
            {
                mas[i]= mas[i] * b;
            }
            Console.WriteLine();
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("otvet " + mas[i]);
            }
            Console.ReadKey();
        }
    }
}
