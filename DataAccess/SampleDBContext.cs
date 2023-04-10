using GraphQLDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.DataAccess
{
    public class SampleDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseInMemoryDatabase(databaseName: "AuthorName");
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
