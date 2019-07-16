using System;
using System.Collections.Generic;
using System.Text;
using VideoStore.Services;

namespace VideoStore.Services
{
    public class RegularPriceCalculator : IPriceCalculator
    {
        public double GetPrice(double daysRented)
        {
            var price = 2.0;
            if (daysRented > 2)
                price += (daysRented - 2) * 1.5;
            return price;
        }
    }
}
