using GraphQLDemo.Models.Entities;

namespace GraphQLDemo.Service.Interface
{
    public interface ICommentService
    {
        Task<Comment> GetComment(int id);
        Task<List<Comment>> GetAllComment();
        Task<Comment> CreateComment(Comment comment);
        Task<bool> DeleteComment(int id);
        Task<Comment> UpdateComment(Comment comment);
    }
}
