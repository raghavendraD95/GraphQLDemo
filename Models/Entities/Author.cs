namespace GraphQLDemo.Models.Entities
{
    public class Author: BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
