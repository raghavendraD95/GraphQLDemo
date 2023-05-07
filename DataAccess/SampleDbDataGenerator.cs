﻿using GraphQLDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace GraphQLDemo.DataAccess
{
    public class SampleDbDataGenerator
    {
        public static void InitializeData(IServiceProvider serviceProvider)
        {
            using (var context = new SampleDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<SampleDBContext>>()))
            {
                if (context.Posts.Any())
                {
                    return;
                }
                var authorText = File.ReadAllText(@"./DataAccess/Datafiles/Authors.json");
                var authorsData = JsonSerializer.Deserialize<List<Author>>(authorText);
                context.Authors.AddRange(authorsData);
               
                var commentsText = File.ReadAllText(@"./DataAccess/datafiles/Comments.json");
                var commentsData = JsonSerializer.Deserialize<List<Comment>>(commentsText);
                context.Comments.AddRange(commentsData);

                var postsText = File.ReadAllText(@"./DataAccess/datafiles/Posts.json");
                var postsData = JsonSerializer.Deserialize<List<Post>>(postsText);
                context.Posts.AddRange(postsData);

                context.SaveChanges();
            }
        }
    }
}
