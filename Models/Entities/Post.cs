namespace GraphQLDemo.Models.Entities
{
    public class Post:BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
