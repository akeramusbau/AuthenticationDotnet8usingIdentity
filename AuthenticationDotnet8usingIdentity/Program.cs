using LibraryAPI.Datalayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AuthenticationDotnet8usingIdentity.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AuthenticationDotnet8usingIdentityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthenticationDotnet8usingIdentityContext") ?? throw new InvalidOperationException("Connection string 'AuthenticationDotnet8usingIdentityContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Datacontextidentity>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<Datacontextidentity>();
builder.Services.AddAuthorization();

var app = builder.Build();

app.MapIdentityApi<IdentityUser>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
