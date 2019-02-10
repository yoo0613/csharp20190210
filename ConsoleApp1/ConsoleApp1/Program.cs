using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private int m = 88, n = 99;
        /*
        Program()
        {
            this.m = 0;
            this.n = 0;
        }
        */
        //생성자
        Program(int m = 0, int n = 0)
        {
            this.m = m;
            this.n = n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(j:10,i:20));
            Console.WriteLine(Sum(j: 10));
            Console.WriteLine(Sum(20));
            Console.WriteLine(Sum());

            Program p1 = new Program();
            Console.WriteLine($"m={p1.m}, n = {p1.n}");

            Program p2 = new Program(1, 2);
            Console.WriteLine($"m={p2.m}, n = {p2.n}");
        }

        static int Sum(int i=0, int j=0)
        {
            return i + j;
        }
    }
}
