using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaVarijable4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite temperaturu u Fahrenheitima: ");
            int F = Convert.ToInt32(Console.ReadLine());
            int C = (F - 32) * 5 / 9;
            Console.WriteLine(F + " Farenhitea = " + C + " Celsiusa ");

            Console.ReadKey();
        }
    }
}