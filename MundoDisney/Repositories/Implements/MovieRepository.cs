using DisneyWorld.Data;
using DisneyWorld.Data.EFCore;
using DisneyWorld.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Repositories.Implements
{
    public class MovieRepository: GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Movie> GetMovieByTitle(string title)
        {
            return await _context.Movies.Where(x => x.Title == title).FirstOrDefaultAsync();
        }

        public async Task<List<Movie>> GetOrderByDate(string criteria)
        {
            return await _context.Movies.OrderBy(x => x.Date).ToListAsync();
        }

    }
}
