namespace VideoStore
{
    public class Rental
    {
        public Rental(Movie movie, int daysRented)
        {
            this.Movie = movie;
            this.DaysRented = daysRented;
        }

        //public int GetDaysRented()
        //{
        //    return DaysRented;
        //}

        public Movie GetMovie()
        {
            return Movie;
        }

        public Movie Movie { get; set; }
        public int DaysRented { get; set; }
    }
}
