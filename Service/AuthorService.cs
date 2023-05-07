using GraphQLDemo.DataAccess.Interface;
using GraphQLDemo.Models.Entities;
using GraphQLDemo.Service.Interface;

namespace GraphQLDemo.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorREpository)
        {
            _authorRepository = authorREpository;
        }
        public async Task<Author> CreateAuthor(Author author)
        {
            return await _authorRepository.Create(author);
        }

        public async Task<bool> DeleteAuthor(int id)
        {
            return await _authorRepository.Delete(id);
        }

        public async Task<List<Author>> GetAllAuthor()
        {
            return await _authorRepository.GetAll();
        }

        public async Task<Author?> GetAuthor(int id)
        {
            return await _authorRepository.GetById(id);
        }

        public async Task<Author> UpdateAuthor(Author author)
        {
            return await _authorRepository.Update(author);
        }
    }
}