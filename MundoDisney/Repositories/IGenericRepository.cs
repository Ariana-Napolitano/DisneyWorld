using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Data
{
    public interface IGenericRepository<T> where T : Identifiable
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T identifiable);
        Task<T> Update(T identifiable);
        Task<T> Delete(int id);

    }
}
