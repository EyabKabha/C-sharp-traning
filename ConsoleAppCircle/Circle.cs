using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCircle
{
    class Circle
    {

        public int axisx { get; set; }
        public int axisy { get; set; }
        public string Color { get; set; }

        private int raduis;

        public int Raduis
        {
            get { return raduis; }
            set
            {
                if (value >= 0)
                    raduis = value;
            }
        }
        public int CalcInside()
        {
            decimal sum;
            sum = (decimal)(3.14159265358979 * (Raduis * Raduis));
            return (int)sum;
        }
        public int circumference()
        {
            decimal total;
            total = (decimal)(2 * 3.14159265358979) * Raduis;
            return (int)total;
        }
        public string GetInfo()
        {
            return $"axisx --> {axisx}\naxisy --> {axisy}\nColor --> {Color}\nraduis --> {Raduis}\n";
        }
        public int GetInfo1()
        {
            Console.Write("Cricle Area is ");
            return CalcInside();
        }
        public int GetInfo2()
        {
            Console.Write("Circumference is ");
            return circumference();
        }
        public Circle()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Circle is created");
            Console.WriteLine("--------------------");
        }
    }
}
