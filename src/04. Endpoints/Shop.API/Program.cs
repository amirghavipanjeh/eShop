using MediatR;
using Microsoft.EntityFrameworkCore;
using Shop.API.Configurations;
using Shop.Catalog.Application.Contracts.ParentCategory;
using Shop.Catalog.Domain.Contracts;
using Shop.Catalog.Persistence.EntityFramework;
using Shop.Catalog.Persistence.EntityFramework.ParentCategories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CatalogDbContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IParentCategoryRepository, ParentCategoryRepository>();

// Configure MediatR
//builder.Services.AddMediatR(typeof(Program));
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));

builder.Services.AddMediatR(typeof(CreateParentCategoryCommand).Assembly);

//builder.Services.AddMediatR(Assembly.Load(typeof(CreateParentCategoryCommand).GetTypeInfo().Assembly.GetName().Name),
//     Assembly.Load(typeof(CatalogDbContext).GetTypeInfo().Assembly.GetName().Name));



var app = builder.Build();






// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
