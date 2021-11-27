using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Data
{
    public interface ICharacterRepository: IGenericRepository<Character>
    {
        Task<Character> GetCharacterByName(string name);
        Task<List<Character>> GetCharactersByAge(int age);

        //Task<List<Character>> GetCharactersByMovie(int idMovie);
    }
}
