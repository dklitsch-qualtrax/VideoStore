namespace VideoStore
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        public string Title { get; set; }
        public int PriceCode { get; set; }

        public Movie(string title, int priceCode)
        {
            this.Title = title;
            this.PriceCode = priceCode;
        }

        //public int GetPriceCode()
        //{
        //    return priceCode;
        //}

        public void SetPriceCode(int code)
        {
            PriceCode = code;
        }

        public string GetTitle()
        {
            return Title;
        }

        public double GetPrice(double daysRented)
        {
            var price = 0.0;
            switch (PriceCode)
            { 
                case Movie.REGULAR:
                    price += 2;
                if (daysRented > 2)
                        price += (daysRented - 2) * 1.5;
                break;
            case Movie.NEW_RELEASE:
                    price += daysRented * 3;
                break;
            case Movie.CHILDRENS:
                    price += 1.5;
                if (daysRented > 3)
                        price += (daysRented - 3) * 1.5;
                break;
            }

            return price;
        }
    }
}
