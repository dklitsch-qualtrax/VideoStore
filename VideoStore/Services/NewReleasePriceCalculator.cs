using System;
using System.Collections.Generic;
using System.Text;

namespace VideoStore.Services
{
    public class NewReleasePriceCalculator : IPriceCalculator
    {
        public double GetPrice(double daysRented)
        {
            return (daysRented * 3);
        }
    }
}
