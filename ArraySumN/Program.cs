using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 3, 4, 3, -2 };
            Random rnd = new Random();
            int n = rnd.Next(1, 100);

            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] += n - a1[i];
                Console.Write(a1[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}
