using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Square
    {
        int side, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter side");
            side = byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = side * side;
        }
        public void DisplayArea()
        {
            Console.WriteLine("area is " + area);
        }
    }


    internal class Rectangle
    {
        int l,b, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter l");
            l = byte.Parse(Console.ReadLine());

            Console.WriteLine("enter b");
            b= byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = l * b;
        }
        public void DisplayArea()
        {
            Console.WriteLine("area is " + area);
        }
    }




    internal class Triangle
    {
        int Base, h, area;
        public void GetDimensions()
        {
            Console.WriteLine("enter BAse");
            Base = byte.Parse(Console.ReadLine());

            Console.WriteLine("enter h");
            h = byte.Parse(Console.ReadLine());
        }
        public void CalculateArea()
        {
            area = (int).5 * Base * h;
        }
        public void DisplayArea()
        {
            Console.WriteLine("area is " + area);
        }
    }
}
