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
                   System.Console.WriteLine("FizzBuzz ");
                else if (i % 3 == 0)
                   System.Console.WriteLine("Fizz ");
                else if (i % 5 == 0)
                   System.Console.WriteLine("Buzz ");
                else
                   System.Console.WriteLine(i);
                
            }
        }
    }
}
