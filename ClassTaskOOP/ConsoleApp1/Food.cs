
namespace _03_inheritance
{
    class Food
    {
        //propfull
        private decimal price;
 
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        //prop
        public bool IsVeg { get; set; }

        public Food(decimal price, bool isVeg )
        {
            Price = price;
            IsVeg = isVeg;
        }
    }
}