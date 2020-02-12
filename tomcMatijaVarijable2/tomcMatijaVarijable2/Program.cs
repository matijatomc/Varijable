using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaVarijable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi niz znakova");
            string niz = Console.ReadLine();

            string sVelika = niz.ToUpper();
            string sMala = niz.ToLower();
            string sPrvaTri = niz.Substring(0, 3);
            string sZadnjihPet = niz.Substring(niz.Length - 5);

            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjihPet);

            if (niz.Length > 10)
            {
                string s8_11 = niz.Substring(8, 11);
                Console.WriteLine(s8_11);
            }
            else
            {
                Console.WriteLine("Nemogu prinaći niz od 8 do 11 znaka");
            }

            Console.ReadKey();
        }
    }
}
