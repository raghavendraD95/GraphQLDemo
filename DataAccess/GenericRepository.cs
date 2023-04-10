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
        public async Task Create(TEntity entity)
        {
            _sampleDbContext.Set<TEntity>().Update(entity);
            await _sampleDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _sampleDbContext.Set<TEntity>().Remove(entity);
            await _sampleDbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _sampleDbContext.Set<TEntity>().AsNoTracking();
        }

        public Task<TEntity?> GetById(int id)
        {
            return _sampleDbContext.Set<TEntity>().SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task Update(TEntity entity)
        {
            _sampleDbContext.Set<TEntity>().Update(entity);
            await _sampleDbContext.SaveChangesAsync();
        }
    }
}
