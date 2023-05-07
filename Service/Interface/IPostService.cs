using GraphQLDemo.Models.Entities;

namespace GraphQLDemo.Service.Interface
{
    public interface IPostService
    {
        Task<Post?> GetPost(int id);
        Task<List<Post>> GetAllPost();
        Task<Post> CreatePost(Post post);
        Task<bool> DeletePost(int id);
        Task<Post> UpdatePost(Post post);
    }
}
