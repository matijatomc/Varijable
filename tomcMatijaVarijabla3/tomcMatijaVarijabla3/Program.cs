using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaVarijabla3
{
    class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();
            niz = niz.Replace(" ", "_");
            Console.WriteLine(niz);

            Console.ReadKey();
        }
    }
    
}
