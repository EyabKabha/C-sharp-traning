using _03_inheritance;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Chips:Food
    {
        private bool isExtaBig;

        public bool IsExtaBig
        {
            get { return isExtaBig; }
            set { isExtaBig = value; }
        }
        private bool isWithDipps;

        public bool IsWithDipps
        {
            get { return isWithDipps; }
            set { isWithDipps = value; }
        }
        public Chips(bool isExtaBig,bool isWithDipps, decimal price, bool isVeg):base (price,isVeg)
        {
            IsExtaBig = isExtaBig;
            IsWithDipps = isWithDipps;
        }
    }
}
