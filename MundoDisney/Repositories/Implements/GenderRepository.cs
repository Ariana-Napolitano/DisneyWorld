using DisneyWorld.Data;
using DisneyWorld.Data.EFCore;
using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Repositories.Implements
{
    public class GenderRepository: GenericRepository<Gender>, IGenderRepository
    {
        public GenderRepository(ApplicationDbContext context) : base(context) { }

    }
}
