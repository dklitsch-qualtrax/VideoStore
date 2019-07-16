namespace VideoStore
{
    public class Rental
    {
        public Rental(Movie movie, int daysRented)
        {
            this.Movie = movie;
            this.DaysRented = daysRented;
        }

        public Movie Movie { get; set; }
        public int DaysRented { get; set; }

        public double GetPrice()
        {
            return Movie.GetPrice(DaysRented);
        }

        public int GetFrequentRenterPoints()
        {
            return (Movie.PriceCode == Movie.NEW_RELEASE && DaysRented > 1) ? 2 : 1;
        }

        public override string ToString()
        {
            return $"\t{Movie.Title}\t{GetPrice()}";
        }
    }
}
