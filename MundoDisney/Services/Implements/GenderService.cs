using DisneyWorld.Models;
using DisneyWorld.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Services.Implements
{
    public class GenderService : GenericService<Gender, IGenderRepository>, IGenderService
    {
        public GenderService(IGenderRepository genderRepository) : base(genderRepository)
        {
        }
    }
}
