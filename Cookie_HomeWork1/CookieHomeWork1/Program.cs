using System;

namespace ConsoleAppHomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" === Cookie number 1 ===");
            Cookie c1 = new Cookie();
            c1.Gluten = "Yes";
            c1.Eggs = 6;
            c1.Amountflour = "3G";
            c1.Sugar = 15;
            Console.WriteLine(c1.Getinfo());
            Console.WriteLine(" === Cookie number 1 ===");
            Cookie c2 = new Cookie();
            c2.Gluten = "False";
            c2.Eggs = 15;
            c2.Amountflour = "35G";
            c2.Sugar = 20;
            Console.WriteLine(c2.Getinfo());
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("||== After Update The Sugar Amount ==||");
            c1.Sugar = 60;
            Console.WriteLine(c1.Getinfo());

            c2 = c1;

            c2.Eggs = 30;
            Console.WriteLine(" === Update ===");
            Console.WriteLine(c1.Getinfo());
            Console.WriteLine(" === Cookie number 2 ===");
            Console.WriteLine(c2.Getinfo());


        } 
    }
}
