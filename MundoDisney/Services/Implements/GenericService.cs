using DisneyWorld.Data;
using DisneyWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyWorld.Services.Implements
{
    public class GenericService<T, R> : IGenericService<T,R> where T : Identifiable where R: IGenericRepository<T>
    {
        protected readonly R repository;

        public GenericService(R genericRepository)//
        {
            this.repository = genericRepository;
        }

        public async Task<List<T>> GetAll()
        {
            return await repository.GetAll();
        }

        public async Task<T> Get(int id)
        {
            return await repository.Get(id);
        }

        public async Task<T> Add(T identifiable)
        {
            return await repository.Add(identifiable);
        }

        public async Task<T> Update(T identifiable)
        {
            return await repository.Update(identifiable);
        }

        public async Task<T> Delete(int id)
        {
            return await repository.Delete(id);
        }
    }
}
