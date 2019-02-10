﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{

    class Triangle1
    {
        private int width;
        private int height;
        private int area;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Area
        {
            get { return width * height / 2; }
        }
    }

    class Triangle2
    {
        public int Width
        {
            get;
            set;
        }
        public int Height
        {
            get;
            set;
        }
        public int Area
        {
            get { return Width * Height / 2; }
        }
    }

    class Program
    {
        static void Main()
        {
            Triangle1 t1 = new Triangle1();
            t1.Width = 6;
            t1.Height = 6;

            Console.WriteLine($"밑변은 {t1.Width}");
            Console.WriteLine($"높이는 {t1.Height}");
            Console.WriteLine($"면적은 {t1.Area}");

            Triangle2 t2 = new Triangle2();
            t2.Width = 6;
            t2.Height = 6;

            Console.WriteLine($"밑변은 {t2.Width}");
            Console.WriteLine($"높이는 {t2.Height}");
            Console.WriteLine($"면적은 {t2.Area}");
        }
    }
}
