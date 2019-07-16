using System;
using VideoStore.Services;
using static VideoStore.Constants.PriceCodes;

namespace VideoStore
{
    public class Movie
    {

        public string Title { get; set; }
        public int PriceCode { get; set; }

        private IPriceCalculator PriceCalculator { get; set; }

        public Movie(string title, int priceCode)
        {
            this.Title = title;
            this.PriceCode = priceCode;

            switch (priceCode)
            {
                case REGULAR:
                    PriceCalculator = new RegularPriceCalculator();
                    break;

                case NEW_RELEASE:
                    PriceCalculator = new NewReleasePriceCalculator();
                    break;

                case CHILDRENS:
                    PriceCalculator = new ChildrensMoviePriceCalculator();
                    break;

                default:
                    throw new Exception("Unknown Price Code");
            }
        }

        public double GetPrice(double daysRented)
        {
            return PriceCalculator.GetPrice(daysRented);
        }
    }
}
