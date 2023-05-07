using GraphQLDemo.DataAccess;
using GraphQLDemo.DataAccess.Interface;
using GraphQLDemo.Service.Query;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IAuthorRepository, AuthorRepository>();
builder.Services.AddTransient<IPostRepository, PostRepository>();
builder.Services.AddTransient<ICommentRepository, CommentRepository>();
builder.Services.AddDbContext<SampleDBContext>(options => options.UseInMemoryDatabase("SampleDb"));


//graphQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType<AuthorQuery>();

var app = builder.Build();

app.MapGraphQL();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    //3. Get the instance of BoardGamesDBContext in our services layer
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<SampleDBContext>();

    //4. Call the DataGenerator to create sample data
    SampleDbDataGenerator.InitializeData(services);
}

//SampleDbDataGenerator.InitializeData(app.Services);

app.Run();
