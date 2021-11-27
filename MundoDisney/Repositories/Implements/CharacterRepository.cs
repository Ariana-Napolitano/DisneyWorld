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
    public class CharacterRepository :  GenericRepository<Character> , ICharacterRepository
    {
        public CharacterRepository(ApplicationDbContext context) : base(context) { }

        public async Task<Character> GetCharacterByName(string Name)
        {
            return await _context.Characters.Where(x => x.Name == Name).FirstOrDefaultAsync();
        }

        public async Task<List<Character>> GetCharactersByAge(int age)
        {
            return await _context.Characters.Where(x => x.Age == age).ToListAsync();
        }

        /*public async Task<List<Character>> GetCharactersByMovie(int idMovie)
        {
            return await _context.Characters.All( );
        }*/
    }

   
}
