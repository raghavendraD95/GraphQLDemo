using GraphQLDemo.Models.Entities;

namespace GraphQLDemo.DataAccess.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity?> GetById(int id);
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
    }
}
