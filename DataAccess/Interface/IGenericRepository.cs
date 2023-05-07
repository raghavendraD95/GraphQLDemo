using GraphQLDemo.Models.Entities;

namespace GraphQLDemo.DataAccess.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity?> GetById(int id);
        Task<TEntity> Create(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<bool> Delete(int id);
    }
}
