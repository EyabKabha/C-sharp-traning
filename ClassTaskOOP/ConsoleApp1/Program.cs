using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] foodArray = new Food[6];
            foodArray[0] = new Pizza(80, false, 4, 2);
            foodArray[1] = new Pizza(40, false, 4, 2);
            foodArray[2] = new Pizza(30, true, 4, 2);
            foodArray[3] = new Chips(true, true, 158, false);
            foodArray[4] = new Chips(true, true, 18, false);
            foodArray[5] = new Chips(true, true, 20, true);

            for (int i = 0; i < foodArray.Length; i++)
            {
                Console.WriteLine("===================");
                Console.WriteLine("is veg ? " + foodArray[i].IsVeg);
                Console.WriteLine($"The Price is : " + foodArray[i].Price);
                Console.WriteLine("===================");

                if (foodArray[i] is Chips){
                    Console.WriteLine($"=== Item {i+1} ===");
                    Console.WriteLine($"have dipps? " + ((Chips)foodArray[i]).IsWithDipps);
                    Console.WriteLine($"is Extra Big?? " + ((Chips)foodArray[i]).IsExtaBig);
                
                }else{
                    Console.WriteLine($"=== Item {i + 1} ===");
                    Console.WriteLine($"num of slices : " + ((Pizza)foodArray[i]).NumOfSlices);
                    Console.WriteLine($"num of toppings: " + ((Pizza)foodArray[i]).NumOftoppings);
                }
            }
        }
    }
}
