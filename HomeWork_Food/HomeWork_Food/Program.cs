using System;

namespace HomeWork_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] arr= new Food[5];
            arr[0] = new Food("Coffe", 35, true, "Osim", 2019);
            arr[1] = new Food("apple juice", 15, false, "Bregat", 2018);
            arr[2] = new Food("Sugar", 20, true, "Osim", 2020);
            arr[3] = new Food("cigarette", 40, false, "Bregat", 2015);
            arr[4] = new Food("Bamba", 10, true, "Osim", 2019);

            for (int i = 0; i <arr.Length; i++)
            {
                Console.WriteLine($"========= Item {i + 1} =========");
                Console.WriteLine(arr[i].GetInfo());
                Console.WriteLine("Is expire day ? " + arr[i].expDatePass());
              
            }
        }
    }
}
