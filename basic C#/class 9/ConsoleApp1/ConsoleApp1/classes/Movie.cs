using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.classes
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }
        public Movie(string title, Genre genre,int rating)
        {
            Title = title;
            Genre = genre;
            if (rating > 5 || rating < 1)
            {
                throw new Exception("the rating  should be between 1-5");
            } else  {
                Rating = rating;
            }
            TicketPrice = rating * 5;
        }

    }

    public enum Genre
    {
        Comedy,
            Horor,
            Action,
            Drama,
            SciFi
    }

    public class Cinema
    {
        public string Name;
        public int Halls;
        public List<Movie> ListOfMovies;
        
        public void MoveiPlaying(Movie movie)
        {
            Console.WriteLine($"the move{movie.Title} is playing");
        }

        public Cinema(string name, int numOfHalls)
        {
            Name = name;
            Halls = numOfHalls;
            
        }
    }

}

