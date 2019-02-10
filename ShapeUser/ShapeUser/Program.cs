using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Shapes;

namespace ShapeUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1.0f);
            Console.WriteLine($"Area of Circle(1.0f) is {c.Area()}");
        }
    }
}
