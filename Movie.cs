using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_2___Class_Methods
{
    public class Movie
    {
        //PROPERTIES
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }



        //CONSTRUCTOR
        public Movie(string title, string genre, double rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }

        // === METHODS ===
        // 

        public static List<Movie> FilterMoviesByRating(List<Movie> userMovieList)
        {
            List<Movie> goodMovieList = new List<Movie>();

            foreach (var movie in userMovieList)
            {
                if (movie.Rating >= 7)
                {
                    goodMovieList.Add(movie);
                }
            }

            return goodMovieList;
        }

        //public static Dictionary<string, double> MovieWatchable(Dictionary<string, double> userMovieList, double rating)
        //{
        //    Dictionary<string, double> goodMovieList = new Dictionary<string, double>();

        //    foreach (var movie in userMovieList)
        //    {
        //        if (movie.Value >= 7)
        //        {
        //            goodMovieList.Add(movie.Key, movie.Value);
        //        }
        //    }

        //    return goodMovieList;


        //for (int i = 0; i < userMovieList.Count; i++)
        //{
        //    if (userMovieList.ContainsValue(5))
        //    {
        //        goodMovieList[i] = userMovieList[i];
        //    }
    }
    // === END OF METHODS === 
}