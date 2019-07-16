using System;

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

        public double GetPrice(double daysRented)
        {
            switch (PriceCode)
            { 
                case Movie.REGULAR:
                    return CalculateRegularPrice(daysRented);

                case Movie.NEW_RELEASE:
                    return CalculateNewReleasePrice(daysRented);

                case Movie.CHILDRENS:
                    return CalculateChildrensMoviePrice(daysRented);

                default:
                    throw new Exception("Unknown Price Code");
            }
        }

        public double CalculateRegularPrice(double daysRented)
        {
            var price = 2.0;
            if (daysRented > 2)
                price += (daysRented - 2) * 1.5;
            return price;
        }

        public double CalculateNewReleasePrice(double daysRented)
        {
            return (daysRented * 3);
        }

        public double CalculateChildrensMoviePrice(double daysRented)
        {
            var price = 1.5;
            if (daysRented > 3)
                price += (daysRented - 3) * 1.5;
            return price;
        }
    }
}
