﻿using System;

namespace NonPrimtiveTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            System.Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            
            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array1[0] = 0;
            System.Console.WriteLine();
        }

    }
}
