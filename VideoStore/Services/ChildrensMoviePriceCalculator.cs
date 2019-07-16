using System;
using System.Collections.Generic;
using System.Text;

namespace VideoStore.Services
{
    public class ChildrensMoviePriceCalculator : IPriceCalculator
    {
        public double GetPrice(double daysRented)
        {
            var price = 1.5;
            if (daysRented > 3)
                price += (daysRented - 3) * 1.5;
            return price;
        }
    }
}
