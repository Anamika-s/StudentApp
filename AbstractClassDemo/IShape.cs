using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo2
{
    // syntactical contract in which none of the methods are defined
    internal interface IShape
    {
        public void GetDimensions();
        public void CalculateArea();
        public void DisplayArea();

    }
    // interfaces are implemented by classes :
    class Square : IShape
    {
        public void CalculateArea()
        {
             
        }

        public void DisplayArea()
        {
             
        }

        public void GetDimensions()
        {
            
        }
    }

    class Rectangle : IShape
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    // multiple inheritance is possible bec of interfaces

    interface I1
    {
        public void Get1();
        public void Get2();
    }

    interface I2
    {
        public void Get2();
        public void Get3();
        public void Get4();
    }

    // multiple inheritance
    class Class1 : I1, I2
    {
        public void Get1()
        {
            throw new NotImplementedException();
        }

        public void Get2()
        {
            throw new NotImplementedException();
        }

        void I2.Get2()
        {

        }
        public void Get3()
        {

        }
        public void Get4()
        {

        }
    }

    class Triangle : IShape
    {
        void IShape.CalculateArea()
        {
            throw new NotImplementedException();
        }

        void IShape.DisplayArea()
        {
            throw new NotImplementedException();
        }

        void IShape.GetDimensions()
        {
            throw new NotImplementedException();
        }
    }


}
