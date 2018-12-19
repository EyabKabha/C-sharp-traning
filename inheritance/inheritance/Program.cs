using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza p1 = new Pizza();
            p1.Price = 90;
            p1.IsVeg = false;
            p1.NumSlices = 8;

            Console.WriteLine($"Our Pizza Has {p1.NumSlices} slices and costs {p1.Price}");
            Console.WriteLine("The Pizza is: " + ((p1.IsVeg) ? "Veg" : "non-veg"));
        }
    }
}
