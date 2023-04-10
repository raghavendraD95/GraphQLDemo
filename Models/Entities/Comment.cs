namespace GraphQLDemo.Models.Entities
{
    public class Comment: BaseEntity
    {
        public string Content { get; set; } = string.Empty; 
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
