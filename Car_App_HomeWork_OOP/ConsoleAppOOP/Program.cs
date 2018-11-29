using System;

namespace ConsoleAppOOP
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            //2.1
            Car1.Speed = 5;
            //2.2
            Console.WriteLine(Car1.GetInfo());
            //2.3
            Console.WriteLine("How much speed-up would you like to add?");
            int usSpeed = Convert.ToInt32(Console.ReadLine());
            Car1.Speed += usSpeed;
            //2.4
            Console.WriteLine(Car1.GetInfo());

            //2.5 + 2.6
            Console.WriteLine("Speed Lower -2 KM");
            Car1.Speed -= 2;
            Console.WriteLine(Car1.GetInfo());
            //2.7
            Console.WriteLine("Stop The Car!!");
            Car1.Speed = 0;
            Console.WriteLine(Car1.GetInfo());


        }
    }
}
