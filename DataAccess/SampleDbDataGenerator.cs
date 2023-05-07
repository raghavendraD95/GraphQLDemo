using GraphQLDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.DataAccess
{
    public class SampleDbDataGenerator
    {
        public static InitializeData(IServiceProvider serviceProvider)
        {
            using (var context = new SampleDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<SampleDBContext>>()))
            {
                if (context.Posts.Any())
                {
                    return;
                }

                context.Posts.AddRange(
                    new Post
                    {
                        Id = 1,

                    }
                    );
            }
        }
    }
}
