using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
{
    class Program
    {
        //static void swap(out int a, out int b)
        static void swap(ref int a, ref int b)
        {
            //a = 10; b = 20;
            int temp = a;  a = b; b = temp;
        }

        static void Main(string[] args)
        {

            int a = 10; int b = 20;

            //Console.WriteLine($"a= {a}, b = {b}");
            //swap(out a,out b);
            swap(ref a, ref b);
            Console.WriteLine($"a= {a}, b = {b}");
        }
    }
}
