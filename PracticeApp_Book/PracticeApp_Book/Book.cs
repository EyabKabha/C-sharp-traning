using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp_Book
{
    class Book
    {
        private string bookN;

        public string BookN
        {
            get { return bookN; }
            set { bookN = value; }
        }
        private string bookA;

        public string BookA
        {
            get { return bookA; }
            set { bookA = value; }
        }
        private int pages;

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        private float price;

        public float Price
        {
            get { return  price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return string.Format($"BookName :{bookN}\nAuthor :{bookA}\npages :{pages}\nprice :{price}");
        }
        

    }
}
