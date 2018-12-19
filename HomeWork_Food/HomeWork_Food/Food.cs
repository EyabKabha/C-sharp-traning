using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Food
{
    class Food
    {
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private bool kasher;

        public bool Kasher
        {
            get { return kasher; }
            set { kasher = value; }
        }
        private string manufacturername;

        public string Manufacturername
        {
            get { return manufacturername; }
            set { manufacturername = value; }
        }
        private int expirationyear;

        public int Expirationyear
        {
            get { return expirationyear; }
            set { expirationyear = value; }
        }
        public Food(string productName, int price, bool kasher, string manufacturername, int expirationyear)
        {
            ProductName = productName;
            Price = price;
            Kasher = kasher;
            Manufacturername = manufacturername;
            Expirationyear = expirationyear;
        }
        public string GetInfo()
        {
            return $"productName : {ProductName}\nPrice : {Price}\nmanufacturername : {Manufacturername}\nkosher : {Kasher}\nexpirationyear : {Expirationyear}";

        }
        public string expDatePass()
        {
            if (Expirationyear <= 2018)
                return $"Yes";
            else
                return $"No";
        }
    }
}
