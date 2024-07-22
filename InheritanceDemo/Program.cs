namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTime = new FullTimeEmployee(
            10, "ajay", "delhi", "ravi", 8987.6f);
            fullTime.GetDetails();
            //fullTime.GetFullTimeEmployeeDetails();
            fullTime.DisplayDetails();
            //fullTime.GetFullTimeEmployeeDetails();
            PartimeEmployee partime
                = new PartimeEmployee();
            partime.GetDetails();
            partime.DisplayDetails();


        }
    }
}
