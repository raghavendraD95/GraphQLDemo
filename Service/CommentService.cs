using GraphQLDemo.DataAccess.Interface;
using GraphQLDemo.Models.Entities;
using GraphQLDemo.Service.Interface;

namespace GraphQLDemo.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentREpository)
        {
            _commentRepository = commentREpository;

        }
        public async Task<Comment> CreateComment(Comment comment)
        {
            return await _commentRepository.Create(comment);
        }

        public async Task<bool> DeleteComment(int id)
        {
            return await _commentRepository.Delete(id);
        }

        public async Task<List<Comment>> GetAllComment()
        {
            return await _commentRepository.GetAll();
        }

        public async Task<Comment?> GetComment(int id)
        {
            return await _commentRepository.GetById(id);
        }

        public async Task<Comment> UpdateComment(Comment comment)
        {
            return await _commentRepository.Update(comment);
        }
    }
}
