using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Demo
{
    internal abstract class Shape
    {
        protected int area;
        public abstract void GetDetails();
        public abstract void CalculateArea();
        public void DisplayArea()
        {
            Console.WriteLine("area is " + area);
        }
    }

    class Square : Shape
    {
        int side;

        public override void CalculateArea()
        {
            area = side * side;
        }

        public override void GetDetails()
        {
            Console.WriteLine("enter side");
            side = byte.Parse(Console.ReadLine());
             
        }
    }

    class Rectangle : Shape
    { int l, w;
        public override void CalculateArea()
        {
            area = l * w;
        }

        public override void GetDetails()
        {
            Console.WriteLine("enter l");
            l = byte.Parse(Console.ReadLine());

            Console.WriteLine("enter w");
            w = byte.Parse(Console.ReadLine());
        }
    }
}
