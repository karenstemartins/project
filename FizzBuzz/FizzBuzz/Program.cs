﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                   System.Console.WriteLine("FizzBuzz123");
                else if (i % 3 == 0)
                   System.Console.WriteLine("Fizz321 ");
                else if (i % 5 == 0)
                   System.Console.WriteLine("Buzzz ");
                else
                   System.Console.WriteLine(i);
                
            }
        }
    }
}
