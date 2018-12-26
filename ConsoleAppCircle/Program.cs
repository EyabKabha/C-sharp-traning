using System;

namespace ConsoleAppCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("=========================");
            Console.WriteLine("Please enter your choice\n1 to check your cricle\n2 to check Your Square");
            Console.WriteLine("=========================");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Circle c1 = new Circle();
                    Console.WriteLine("===================");
                    Console.WriteLine("Please enter a data for your Circle");
           
                    Console.WriteLine("Enter axis x ");
                    c1.axisx = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter axis y ");
                    c1.axisy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Your Color");
                    c1.Color = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter Raduis");
                    c1.Raduis = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("====================");
                    Console.WriteLine("Your Data Circle");
                    Console.WriteLine("--------------------");
                    Console.Write(c1.GetInfo());
                    Console.WriteLine("--------------------");
                    Console.WriteLine(c1.GetInfo1());
                    Console.WriteLine(c1.GetInfo2());
                    Console.WriteLine("--------------------");
                    break;
                case 2:
                    Square s1 = new Square();
                    Console.WriteLine("Please enter a data for your Square");
                    Console.WriteLine("Enter axis x ");
                    s1.axisx = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter axis y ");
                    s1.axisy = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Your Color");
                    s1.Color = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter length rib ");
                    s1.Lengthrib = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("====================");
                    Console.WriteLine("Your Data Square");
                    Console.WriteLine("--------------------");
                    Console.Write(s1.GetInfoSquare());
                    Console.WriteLine("--------------------");
                    Console.WriteLine(s1.GetInfoSquareInside());
                    Console.WriteLine(s1.circumferencerib());
                    Console.WriteLine("--------------------");
                    break;
                default:
                    Console.WriteLine("Wrong Choice!!\n");
                    break;
            }
        }
    }
}
