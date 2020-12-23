using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        [DllImport("D:\\SzE\\Programozassajat\\szerepjatek\\c++&c#\\CPPDLL\\x64\\Debug\\CPPDLL.dll", CallingConvention=CallingConvention.Cdecl)]
        public static extern IntPtr create();
        [DllImport("D:\\SzE\\Programozassajat\\szerepjatek\\c++&c#\\CPPDLL\\x64\\Debug\\CPPDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void set(string text, IntPtr myobj);
        [DllImport("D:\\SzE\\Programozassajat\\szerepjatek\\c++&c#\\CPPDLL\\x64\\Debug\\CPPDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern string get(IntPtr myobj);
        [DllImport("D:\\SzE\\Programozassajat\\szerepjatek\\c++&c#\\CPPDLL\\x64\\Debug\\CPPDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void deleteobj(IntPtr myobj);
	
        static void Main(string[] args)
        {
        }
    }
}
