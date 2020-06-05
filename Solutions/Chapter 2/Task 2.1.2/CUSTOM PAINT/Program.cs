using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOM_PAINT
{
    class Program
    {
        static void Main(string[] args)
        {

       
    }


}
    class RoundShape
    {
        public int x;
        public int y;
        public int radius;
    }

    class Disc : RoundShape
    {
        public double GetArea() => Math.PI * radius * radius;
        public double GetСircumscribedСircle() => 2 * Math.PI * radius;

    }

    class Ring : RoundShape
    {
        public int innerRadius;
        public double GetArea() => Math.PI * (radius * radius - innerRadius * innerRadius);

        public double GetTotalLenght() => (2 * Math.PI * radius) + (2 * Math.PI * innerRadius);
    } 

    class Square
    {
        public int a;
        public double GetArea() => a * a;
    }

    class Rectangle
    {
        public int a;
        public int b;
        public double GetArea() => a * b;
    }
    class Triangle
    {
        public int a;
        public int b;
        public int c;

        public double halfPerimetr() => (a + b + c) / 2;        
        public double GetArea() => Math.Sqrt(halfPerimetr() * (halfPerimetr() - a) * (halfPerimetr() - b) * (halfPerimetr() - c));


    }

    class Line
    {
        public int a;
        public int b;

    }


}

