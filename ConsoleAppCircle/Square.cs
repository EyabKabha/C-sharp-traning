using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCircle
{
    class Square
    {
        public int axisx { get; set; }
        public int axisy { get; set; }
        public string Color { get; set; }

        private int lengthrib;

        public int Lengthrib
        {
            get { return lengthrib; }
            set
            {
                if (value >= 0)
                    lengthrib = value;
            }
        }
        public string GetInfoSquare()
        {
            return $"axisx --> {axisx}\naxisy --> {axisy}\nColor --> {Color}\nraduis --> {lengthrib}\n";
        }
        public int CalcSquareInside()
        {
            int total;
            total = lengthrib * lengthrib;
            return total;
        }
        public int GetInfoSquareInside()
        {
            Console.Write("Square Area is ");
            return CalcSquareInside();
        }

        public int Calccircumferencerib()
        {
            int sum;
            sum = lengthrib * 4;
            return sum;
        }
        public int circumferencerib()
        {
            Console.Write("Circumferencerib is ");
            return Calccircumferencerib();
        }
        public Square()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Square  is created");
            Console.WriteLine("--------------------");
        }
    }
}
