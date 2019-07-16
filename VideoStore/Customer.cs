using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
            this.Rentals = new List<Rental>();
        }

        public string Statement()
        {
            var totalAmount = Rentals.Select(Rental => Rental.GetPrice()).Sum();
            var frequentRenterPointsTotal = Rentals.Select(rental => rental.GetFrequentRenterPoints()).Sum();
            var lineItemSummaries = String.Join("\n", Rentals);

            return $"Rental Record for {Name}\n" +
                $"{ lineItemSummaries}\n" +
                $"You owed {totalAmount}\n" +
                $"You earned {frequentRenterPointsTotal} frequent renter points\n";
        }


        public String Name { get; set; }
        public List<Rental> Rentals { get; set;}
    }
}
