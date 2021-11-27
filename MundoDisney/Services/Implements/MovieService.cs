using DisneyWorld.Models;
using DisneyWorld.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Services.Implements
{
    public class MovieService: GenericService<Movie, IMovieRepository>, IMovieService
    {
        public MovieService(IMovieRepository movieRepository) : base(movieRepository)
        {
        }

        public async Task<Movie> GetMovieByTitle(string title)
        {
            return await repository.GetMovieByTitle(title);
        }

        public async Task<List<Movie>> GetOrderByDate(string criteria)
        {
            return await repository.GetOrderByDate(criteria);
        }
    }
}
