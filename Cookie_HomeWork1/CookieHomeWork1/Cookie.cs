using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppHomeWork1
{
    class Cookie
    {
        private string gluten;

        public string Gluten
        {
            get { return gluten; }
            set { gluten = value; }
        }

       
        private int eggs;

        public int Eggs
        {
            get { return eggs; }
            set { eggs = value; }
        }

        private int sugar;
        public int Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }

        public string amountflour;
        public string Amountflour
        {
            get { return amountflour; }
            set { amountflour = value; }
        }
        //public Cookie(string gluten,int eggs,int sugar,string AmountFlour)
        //{
        //    Gluten = gluten;
        //    Eggs = eggs;
        //    Sugar = sugar;
        //    Amountflour = amountflour;
        //}
        //public Cookie() { }
        public string Getinfo()
        {
            return $"Eggs :{Eggs}\nGluten :{Gluten}\nSugar {Sugar}\nFlour {Amountflour}";
        }

    }
}
