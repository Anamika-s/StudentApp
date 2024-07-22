using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program2
    {
        static void Main()
        {
            //FullTimeEmployee full = new FullTimeEmployee();
            //Employee emp;
            //emp = new FullTimeEmployee();
            //emp.GetDetails();//  static linking/ eraly linking/ compile time linking
            //emp.DisplayDetails();

            Employee emp;
            Console.WriteLine("enter emp type");
            int ch = byte.Parse(Console.ReadLine());
            if (ch == 1)

                emp = new FullTimeEmployee();
            else
                emp = new PartimeEmployee();

            emp.GetDetails();
            emp.DisplayDetails();
                    // we are talking abt dynamic linking/ late linking/ Dynamic polymorphism
            // which is acheived by method overriding

        }
    }
}
