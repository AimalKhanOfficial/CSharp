﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass some = new SomeClass();
            some[0] = "Aimal";
            Console.WriteLine(some[0]);
            Console.Read();
        }
    }
}
