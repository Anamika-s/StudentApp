using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MultilevLInheritanceDemo
{

    class student
    {
        int rn;
        string name;
        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo");
            rn = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("Name is " + name);
        }
    }

    class sports  : student

    {
        string sportsName;
        protected int score;
        public void GetDetails()
        {
           base.GetDetails();
            Console.WriteLine("Enter Sports Name");
            sportsName = Console.ReadLine();
            Console.WriteLine("Enter Score");
            score = Convert.ToByte(Console.ReadLine());
        }
        public void DisplayDetails()
        {

            base.DisplayDetails();
            Console.WriteLine("Sports Name is " + sportsName);
            Console.WriteLine("Score is " + score);
        }
    }

    class test  : sports
    {
        int[] marks = [90, 89, 89];
        protected int totalMarks;
        public void CalculateTotalMarks()

        {base.GetDetails();
            foreach (int mark in marks)
                totalMarks += mark;
        }
          
        
        public void DisplayDetails()
        {
            base.DisplayDetails();

            Console.WriteLine("totalmarks are " +totalMarks);
        }
    }

    class result   : test
    {
        int FinalScore;
        public void CalculateFinalScore()
        {
            base.CalculateTotalMarks();
            //FinalSCore > score  + totalMArks;
            FinalScore = score + totalMarks;  
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Your Final Score is " + FinalScore);
        }
    }




}
