﻿using System;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (var i = 0; i < 10; i++)
            Console.WriteLine(random.Next());
        }
    }
}
