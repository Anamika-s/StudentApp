namespace AbstractClass_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            Console.WriteLine("enter choice");
            int ch = byte.Parse(Console.ReadLine());
            //Shape shape1 = new Shape();

            switch (ch)
            {
                case 1:
                    shape = new Square();
                    shape.GetDetails();
                    shape.CalculateArea();
                    shape.DisplayArea();
                    break;
                case 2:
                    shape = new Rectangle();
                    shape.GetDetails();
                    shape.CalculateArea();
                    shape.DisplayArea();
                    break;
            }
        }
    }
}
