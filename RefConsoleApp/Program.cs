using System;

namespace RefConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=20, y=10;
            degistir(ref x, ref y);
            Console.WriteLine($"x in yeni deperi : {x}\ny'nin yeni değeri : {y}");
        }
       static void degistir(ref int a,ref int b)
        {
            int gecici = a;
            a = b;
            b = gecici;
           
        }
    }
}
