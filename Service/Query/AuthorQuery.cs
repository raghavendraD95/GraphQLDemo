using GraphQLDemo.DataAccess;
using GraphQLDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDemo.Service.Query
{
    public class AuthorQuery
    {
        public List<Author> GetAuthors([Service] SampleDBContext dBContext)
        {
            return dBContext.Authors.Include(x=>x.Posts).ToList();
        }
        public Author? GetAuthor([Service] SampleDBContext dBContext, int id)
        {
            return dBContext.Authors.FirstOrDefault(x => x.Id == id);
        }
    }
}
