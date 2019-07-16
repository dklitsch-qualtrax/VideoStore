using System;
using System.Collections.Generic;
using System.Text;

namespace VideoStore.Services
{
    public interface IPriceCalculator
    {
        double GetPrice(double daysRented);
    }
}
