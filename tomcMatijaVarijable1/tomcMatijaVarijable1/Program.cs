﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaVarijable1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 100;
            int b = 3;
            int x = a / b;
            int y = a % b;
            Console.WriteLine(a+" dijeljeno s "+b+" je "+x+" i ostatak "+y);

            Console.ReadKey();
        }
    }
}
