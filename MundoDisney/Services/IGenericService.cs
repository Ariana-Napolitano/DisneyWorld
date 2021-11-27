using DisneyWorld.Data;
using DisneyWorld.Data.EFCore;
using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Services
{
    public interface IGenericService<T,R> where T: Identifiable where R: IGenericRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T identifiable);
        Task<T> Update(T identifiable);
        Task<T> Delete(int id);
    }
}
