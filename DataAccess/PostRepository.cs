using GraphQLDemo.DataAccess.Interface;
using GraphQLDemo.Models.Entities;

namespace GraphQLDemo.DataAccess
{
    public class PostRepository:GenericRepository<Post>, IPostRepository
    {
        public PostRepository(SampleDBContext sampleDBContext): base(sampleDBContext)
        {

        }
    }
}
