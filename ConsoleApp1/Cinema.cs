using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cinema
    {
        private string cinemaName;

        public string CinemaName
        {
            get { return cinemaName; }
            set { cinemaName = value; }
        }

        private int priceofmovie;

        public int Priceofmovie
        {
            get { return priceofmovie; }
            set
            {
                if (value >= 30 && value <= 200)
                    priceofmovie = value;
            }
        }
        public readonly int Discountforstudents;
        public readonly int Discountforlecturer;
        Random rnd = new Random();

        public Cinema()
        {
          
            Discountforstudents = rnd.Next(10, 21);
            Discountforlecturer = rnd.Next(5, 11);
        }
        public string GetInfoCinema()
        {

            return $"cinemaName {CinemaName}\nPriceofmovie {Priceofmovie}\ndiscountforstudents {Discountforstudents}\ndiscountforlecturer {Discountforlecturer}";
        }
    }
}
