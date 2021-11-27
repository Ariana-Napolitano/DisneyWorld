using DisneyWorld.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Data.EFCore
{
    public class GenericRepository<TIdentifiable> : IGenericRepository<TIdentifiable>
         where TIdentifiable : class, Identifiable
        
    {
        protected readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public async Task<TIdentifiable> Add(TIdentifiable identifiable)
        {
            _context.Set<TIdentifiable>().Add(identifiable);
            await _context.SaveChangesAsync();
            return identifiable;
        }

        public async Task<TIdentifiable> Delete(int id)
        {
            var identifiable = await _context.Set<TIdentifiable>().FindAsync(id);
            if (identifiable == null)
            {
                return identifiable;
            }

            _context.Set<TIdentifiable>().Remove(identifiable);
            await _context.SaveChangesAsync();

            return identifiable;
        }

        public async Task<TIdentifiable> Get(int id)
        {
            return await _context.Set<TIdentifiable>().FindAsync(id);
        }

        public async Task<List<TIdentifiable>> GetAll()
        {
            return await _context.Set<TIdentifiable>().ToListAsync();
        }

        public async Task<TIdentifiable> Update(TIdentifiable identifiable)
        {
            _context.Entry(identifiable).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return identifiable;
        }
    }
}
