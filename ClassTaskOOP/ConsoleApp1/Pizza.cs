namespace _03_inheritance
{
    class Pizza: Food
    {
        private int numOfSlices;

        public int NumOfSlices
        {
            get { return numOfSlices; }
            set { numOfSlices = value; }
        }
        private int numOftoppings;

        public int NumOftoppings
        {
            get { return numOftoppings; }
            set { numOftoppings = value; }
        }

        public Pizza(decimal price, bool isVeg, int numOfSlices , int numOftoppings) : base(price, isVeg)
        {
            NumOfSlices = numOfSlices;
            NumOftoppings = numOftoppings;
        }
        
    }
}