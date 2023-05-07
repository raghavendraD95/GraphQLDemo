using GraphQLDemo.DataAccess.Interface;
using GraphQLDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.DataAccess
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly SampleDBContext _sampleDbContext;

        public GenericRepository(SampleDBContext sampleDBContext)
        {
            _sampleDbContext = sampleDBContext;
        }
        public async Task<TEntity> Create(TEntity entity)
        {
            _sampleDbContext.Set<TEntity>().Update(entity);
            await _sampleDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await GetById(id);
            _sampleDbContext.Set<TEntity>().Remove(entity);
            await _sampleDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _sampleDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> GetById(int id)
        {
            return await _sampleDbContext.Set<TEntity>().SingleOrDefaultAsync(x => x.Id == id);
        }

        public async  Task<TEntity> Update(TEntity entity)
        {
            _sampleDbContext.Set<TEntity>().Update(entity);
            await _sampleDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
