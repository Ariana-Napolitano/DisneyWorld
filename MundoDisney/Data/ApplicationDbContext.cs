using Microsoft.EntityFrameworkCore;
using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Gender> Gender { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Character> Characters { get; set; }

    }
}
