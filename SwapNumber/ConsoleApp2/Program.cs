using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Swap(int num1,int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
           
            Console.WriteLine($"after Swap --> {num1}  {num2}");
        }
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Enter number");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Secound number");
             num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before Swap --> {num1}  {num2}");
            Swap(num1,num2);
        }
    }
}
