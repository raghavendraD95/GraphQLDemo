using GraphQLDemo.DataAccess.Interface;
using GraphQLDemo.Models.Entities;

namespace GraphQLDemo.DataAccess
{
    public class AuthorRepository:GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(SampleDBContext sampleDBContext):base(sampleDBContext)
        {
                
        }
    }
}
