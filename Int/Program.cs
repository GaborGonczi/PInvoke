﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Calculator
{
    class Program
    {
        [DllImport("D:\\SzE\\Programozassajat\\szerepjatek\\c++&c#\\CPPDLL\\x64\\Debug\\CPPDLL.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern int addition(int num1, int num2);
        [DllImport("D:\\SzE\\Programozassajat\\szerepjatek\\c++&c#\\CPPDLL\\x64\\Debug\\CPPDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int substraction(int num1, int num2);
        [DllImport("D:\\SzE\\Programozassajat\\szerepjatek\\c++&c#\\CPPDLL\\x64\\Debug\\CPPDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int multiplication(int num1, int num2);
        [DllImport("D:\\SzE\\Programozassajat\\szerepjatek\\c++&c#\\CPPDLL\\x64\\Debug\\CPPDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double division(int num1, int num2);

        static void Main(string[] args)
        {
            int c = addition(4, 5);
            Console.WriteLine(c);
        }
    }
}
