using System;

namespace AppTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Gogo", new Date(17, 4, 1942), null, null);
            Person p2 = new Person("Gigi", new Date(21, 8, 1945), null, null);
            Person p3 = new Person("Momo", new Date(8, 5, 1980), p1, p2);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
        }
    }
}
