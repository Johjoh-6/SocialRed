using Microsoft.EntityFrameworkCore;
using SocialRed.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SocialRedContext>(options => options.UseNpgsql(       
builder.Configuration.GetConnectionString("DefaultConnection") 
));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// using var scope = app.Services.CreateScope();
// await using var dbContext = scope.ServiceProvider.GetRequiredService<SocialRedContext>();
// await dbContext.Database.MigrateAsync();

app.UseSwagger();
app.UseSwaggerUI();


// app.UseHttpsRedirection();

app.Run();
