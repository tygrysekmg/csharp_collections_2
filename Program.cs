﻿using System;
using System.Collections.Generic;


namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
            Console.WriteLine($"Hello {name.ToUpper()}!");
            }

           Console.WriteLine($"My name is {names[0]}.");
           Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

         }
    }
}
