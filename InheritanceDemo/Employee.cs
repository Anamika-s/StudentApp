using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    // emplyees cud be of 2 types
    // parttime  , noOfDays, chargesPerDay, projectName 
    // fulltime , manager, basicSalary
    internal class Employee
    {
        int id;
        string name;
        string address;
        Employee(string name)
        {

        }
        Employee() { }
        public Employee(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public virtual void GetDetails()
        {
            Employee employee = new Employee("aaaaa"); 
            Console.WriteLine("enter id");
            id = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter aaddress");
            address = Console.ReadLine();
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine("id is "  +id);
            Console.WriteLine("name is " + name);
            Console.WriteLine("address is " + address);
        }
    }

    class FullTimeEmployee : Employee
    {
        string manager;
        float basicSalary;
        public FullTimeEmployee() : base() { }
        public FullTimeEmployee(int id, string name, string address,
            string manager, float basicSalary)
            :
            base(id, name, address)
        {
            this.manager = manager;
            this.basicSalary = basicSalary;
        }
        public override void GetDetails()
        //public void GetFullTimeEmployeeDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter manager");
            manager = Console.ReadLine();
            Console.WriteLine("enter basicSalary");
            basicSalary = float.Parse(Console.ReadLine());
        }
        public override void DisplayDetails()
        //public void DisplayFullTimeEmployeeDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Manager is " + manager);
            Console.WriteLine("Salary is " + basicSalary);
        }
        }
    class PartimeEmployee : Employee
    {
        int noOfDays, chargesPerDay;
        string projectName;
        public PartimeEmployee() : base() { }
        public PartimeEmployee(int id, string name, string address,
          int noOfDays,int chargesPerDay, string projectName)
            :
            base(id, name, address)
        {
            this.noOfDays = noOfDays;   
            this.chargesPerDay = chargesPerDay;
            this.projectName = projectName;
        } 
        public void GetDetails()
        //public void GetFullTimeEmployeeDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter noOfDays");
            noOfDays = int.Parse(Console.ReadLine());

            Console.WriteLine("enter chargesPerDay");
            chargesPerDay = int.Parse(Console.ReadLine());
            Console.WriteLine("enter noOfDays");
            projectName = Console.ReadLine();
        }
        public void DisplayDetails()
        //public void DisplayFullTimeEmployeeDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("chargesPerDay are " + chargesPerDay);
            Console.WriteLine("projectName is " + projectName);
        }
    }

}
