using System;

namespace ConsoleApp1
{
    class Program
    {
        static void initArr(Person[] personArr)
        {
            Random rnd = new Random();
            int choice = rnd.Next(0, 3);
            int i;
            for (i = 0; i < personArr.Length; i++)
            {

                switch (choice)
                {
                    case 0:
                        personArr[i] = new Student("Ariel", "Math", "Anna", 25, "318766508", true);
                        break;
                    case 1:
                        personArr[i] = new Teacher("Programing", "8", "Shadi badir", 20, "315486958", false);
                        break;
                    case 2:
                        personArr[i] = new Worker(1520, "EyabKabha", 21, "215486595", true);
                        break;
                    default:
                        break;
                }
            }
        }
        static void PrintInfo(Person[] personArr, Cinema bestCinema)
        {
            decimal total = 0;
            int studentCount = 0;
            int teacherCount = 0;
            int workerCount = 0;

            foreach (Person p in personArr)
            {
                if (p is Student)
                {
                    studentCount++;
                    total += (int)((bestCinema.Priceofmovie) * (decimal)(1 - (bestCinema.Discountforstudents / 100.0)));
                }
                else if (p is Teacher)
                {
                    teacherCount++;
                    total += (int)((bestCinema.Priceofmovie) * (decimal)(1 - (bestCinema.Discountforlecturer / 100.0)));
                }
                else
                {
                    workerCount++;
                    total += bestCinema.Priceofmovie;
                }
               
            }

            Console.WriteLine($"Total for this day: {total}");
            Console.WriteLine($"Price per movie: {bestCinema.Priceofmovie}");
            Console.WriteLine($"Total clients: {personArr.Length}");
            Console.WriteLine($"Total studentCount: {studentCount}");
            Console.WriteLine($"Total teacherCount: {teacherCount}");
            Console.WriteLine($"Total workerCount: {workerCount}");
            Console.WriteLine($"StudentDiscount: {bestCinema.Discountforstudents}");
            Console.WriteLine($"TeacherDiscount: {bestCinema.Discountforlecturer}");
            Console.WriteLine("==================");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Cinema c1 = new Cinema();
            c1.Priceofmovie = 35;
            c1.CinemaName = "Avatar";
            Console.WriteLine(c1.GetInfoCinema());
            Console.WriteLine("==================");
            Person[] arr = new Person[15];

            initArr(arr);
            PrintInfo(arr, c1);
        }
    }
}
