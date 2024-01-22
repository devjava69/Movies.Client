using Movies.Client.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movieList = new List<Movie>();

            movieList.Add
            (
                new Movie
                {
                    Id = 1,
                    Genre = "Comics",
                    Title = "asd",
                    Rating = "9.2",
                    ImageUrl = "images/src",
                    ReleaseDate = DateTime.Now,
                    Owner = "swn"
                }
            );

            return await Task.FromResult( movieList );
        }

        Task<Movie> IMovieApiService.CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        Task IMovieApiService.DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        Task<Movie> IMovieApiService.GetMovieById(string id)
        {
            throw new NotImplementedException();
        }

        Task<Movie> IMovieApiService.UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
