using DisneyWorld.Models;
using DisneyWorld.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Services
{
    public interface IGenderService: IGenericService<Gender, IGenderRepository>
    {
    }
}
