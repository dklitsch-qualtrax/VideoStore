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
            String result = "Rental Record for " + Name + "\n";

            result += String.Join("\n", Rentals.Select(rental => rental.ToString()));
            var totalAmount = Rentals.Select(Rental => Rental.GetPrice()).Sum();
            var frequentRenterPoints = Rentals.Select(rental => rental.GetFrequentRenterPoints()).Sum();

            result += "\nYou owed " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";


            return result;
        }


        public String Name { get; set; }
        public List<Rental> Rentals { get; set;}
    }
}
