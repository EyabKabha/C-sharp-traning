using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Book[] ary = new Book[4];
            ary[0] = new Book();
            ary[0].BookN = "C# Programing";
            ary[0].BookA = "Yousef Ballan";
            ary[0].Pages = 168;
            ary[0].Price = 155;

            ary[1] = new Book();
            ary[1].BookN = "Android Programing";
            ary[1].BookA = "Anna Karpf";
            ary[1].Pages = 758;
            ary[1].Price = 158;

            ary[2] = new Book();
            ary[2].BookN = "C Language";
            ary[2].BookA = "Shayki Bilu";
            ary[2].Pages = 1584;
            ary[2].Price = 1578;

            for (i = 0; i < ary.Length; i++)
            {
                if (ary[i] != null)
                {
                    Console.WriteLine($"=====Book number {i + 1}");
                    Console.WriteLine(ary[i].ToString());
                }
            }

            Console.WriteLine("=========================");
            Console.WriteLine("Enter a Name of Book");
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Author Book");
            string str1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Pages of the book");
            int numBook = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of the book");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====Book number 3");
            Console.WriteLine($"BookName :{str}\nAuthor :{str1}\npages :{numBook}\nprice :{price}");
        }
    }
}
