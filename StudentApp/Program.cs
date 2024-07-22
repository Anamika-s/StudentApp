namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student();
            //student.Rn = -1;
            //Console.WriteLine(student.Rn);

            Student student1 = new Student();
            // new keyword will do 2 things
            // 1. it allocates memory on heap
            // 2. it calls def cons to initialze all the member variables
            // to their def value
            student1.GetDetails();
            student1.DisplayDetails();
            // whuy should we use constructors?
            // to initialize member variables
            Student student2 = new Student(2);
            //student2.GetDetails();
            student2.DisplayDetails();

            Student student3 = new Student(3,"Ajay");
            student3.DisplayDetails();

            Student student4 = new Student(student3);
        }
    }
}
