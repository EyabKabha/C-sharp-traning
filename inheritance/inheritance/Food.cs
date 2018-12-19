using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    class Food
    {
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool IsVeg { get; set; }
    }
}
