using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Car
    {
        private int speed;

        public  int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string GetInfo()
        {
            return $"Your Car speed has: {speed} KM";
        }

    }
}
