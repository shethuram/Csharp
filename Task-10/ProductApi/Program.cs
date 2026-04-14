using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductApi.Services;
using ProductApi.Middleware;

namespace ProductApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //  Add services to container
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //  DB Context
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseInMemoryDatabase("ProductDb"));

            //  Dependency Injection
            builder.Services.AddScoped<IProductService, ProductService>();

            var app = builder.Build();

            //  Swagger (Development only)
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //  IMPORTANT: Middleware should be early
            app.UseMiddleware<ExceptionMiddleware>();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}