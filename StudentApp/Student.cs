using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Student
    {// readonly var can be initialized where?
        // 1. while declaring them
        // 2. within a constr only
        readonly int rn;
        string name;
        string address;
        static string batch;
        const string companyName = "aaa";
        public void GetDetails()
        {
            //Console.WriteLine("enter rn");
            //rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("rn is " + rn);
            Console.WriteLine("name is " + name);
            Console.WriteLine("address is " + address);
        }
       // def constructor, can be 1 only
        public Student() { }
        public Student(int x) // para 
        {
            rn = x;
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter address");
            address = Console.ReadLine();

        }
        // copy const , used to copy values of 1 object to other
        public Student(Student student)
        {
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine()); name = student.name;
            address = student.address;
        }
        public Student(int x, string y)
        {
            rn = x;
            name = y;
            Console.WriteLine("enter address");
            address = Console.ReadLine();

        }
        // static const
        // 1 within a class , also shud be parameterless
        static Student()
        {
            batch = "DotNet";
        }
        // fully para constructor
        public Student(int x, string y, string z)
        {
            rn = x; name = y;
            address = z;
        }

    }
}
