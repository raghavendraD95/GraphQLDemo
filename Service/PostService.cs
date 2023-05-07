using GraphQLDemo.DataAccess.Interface;
using GraphQLDemo.Models.Entities;
using GraphQLDemo.Service.Interface;

namespace GraphQLDemo.Service
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<Post> CreatePost(Post post)
        {
            return await _postRepository.Create(post);
        }

        public async Task<bool> DeletePost(int id)
        {
            return await _postRepository.Delete(id);
        }

        public async Task<List<Post>> GetAllPost()
        {
            return await _postRepository.GetAll();
        }

        public async Task<Post?> GetPost(int id)
        {
            return await _postRepository.GetById(id);   
        }

        public async Task<Post> UpdatePost(Post post)
        {
            return await _postRepository.Update(post);
        }
    }
}
