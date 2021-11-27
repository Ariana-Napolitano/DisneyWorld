using DisneyWorld.Data;
using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Repositories
{
    public interface IMovieRepository: IGenericRepository<Movie>
    {
        Task<Movie> GetMovieByTitle(string title);
        //Task<List<Movie>> GetMoviesByGender(int idGender);
        Task<List<Movie>> GetOrderByDate(string criteria);
        //Task<List<Character>> GetCharactersAssociatedByMovie(int idMovie);
    }
}
