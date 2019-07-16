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
            double totalAmount = 0;
            String result = "Rental Record for " + Name + "\n";
            var frequentRenterPoints = Rentals.Select(rental => rental.GetFrequentRenterPoints()).Sum();

            //var rentalTotal = Rentals.Select(Rental => Rental.GetPrice());
            //var frequentRenterPoints = Rentals.Count();

            foreach (var rental in Rentals)
            {
                double rentalPrice = rental.GetPrice();
                result += "\t" + rental.Movie.Title+ "\t"
                                    + rentalPrice + "\n";
                totalAmount += rentalPrice;
            }

            result += "You owed " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";


            return result;
        }


        public String Name { get; set; }
        public List<Rental> Rentals { get; set;}
    }
}
