using GraphQLDemo.DataAccess.Interface;
using GraphQLDemo.Models.Entities;

namespace GraphQLDemo.DataAccess
{
    public class CommentRepository:GenericRepository<Comment>,ICommentRepository
    {
        public CommentRepository(SampleDBContext sampleDBContext): base(sampleDBContext) 
        {

        }
    }
}
