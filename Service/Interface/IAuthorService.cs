using GraphQLDemo.Models.Entities;

namespace GraphQLDemo.Service.Interface
{
    public interface IAuthorService
    {
        Task<Author?> GetAuthor(int id);
        Task<List<Author>> GetAllAuthor();
        Task<Author> CreateAuthor(Author author);
        Task<bool> DeleteAuthor(int id);
        Task<Author> UpdateAuthor(Author author);
    }
}
