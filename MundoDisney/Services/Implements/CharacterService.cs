using DisneyWorld.Data;
using DisneyWorld.Models;
using DisneyWorld.Repositories.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Services.Implements
{
    public class CharacterService: GenericService<Character, ICharacterRepository>, ICharacterService
    {
      
        public CharacterService(ICharacterRepository characterRepository):base(characterRepository)
        {
        }

        public async Task<Character> GetCharacterByName(string name)
        {
            return await repository.GetCharacterByName(name);
        }

        public async Task<List<Character>> GetCharactersByAge(int age)
        {
            return await repository.GetCharactersByAge(age);
        }

        /*public async Task<List<Character>> GetCharactersByMovie(int idMovie)
        {
            return await repository.GetCharactersByMovie(idMovie);
        }*/
    }
}
