using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            int sum = 0;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-20, 20);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            { 
                   sum = sum + mas[i];  
            }
            Console.WriteLine("otvet " +sum);

            Console.ReadKey();
        }
    }
}
