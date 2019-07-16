using System;
using System.Collections.Generic;

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
            int frequentRenterPoints = 0;
            String result = "Rental Record for " + Name + "\n";

            foreach (var rental in Rentals)
            {
                double thisAmount = 0;

                // determines the amount for each line
                switch (rental.Movie.PriceCode)
                {
                    case Movie.REGULAR:
                        thisAmount += 2;
                        if (rental.DaysRented > 2)
                            thisAmount += (rental.DaysRented - 2) * 1.5;
                        break;
                    case Movie.NEW_RELEASE:
                        thisAmount += rental.DaysRented * 3;
                        break;
                    case Movie.CHILDRENS:
                        thisAmount += 1.5;
                        if (rental.DaysRented > 3)
                            thisAmount += (rental.DaysRented - 3) * 1.5;
                        break;
                }

                frequentRenterPoints++;

                if (rental.Movie.PriceCode == Movie.NEW_RELEASE
                        && rental.DaysRented > 1)
                    frequentRenterPoints++;

                result += "\t" + rental.Movie.GetTitle() + "\t"
                                    + thisAmount + "\n";
                totalAmount += thisAmount;

            }

            result += "You owed " + totalAmount + "\n";
            result += "You earned " + frequentRenterPoints + " frequent renter points\n";


            return result;
        }


        public String Name { get; set; }
        public List<Rental> Rentals { get; set;}
    }
}
