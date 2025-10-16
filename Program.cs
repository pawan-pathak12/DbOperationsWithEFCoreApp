using DbOperationsWithEFCoreApp.Data;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb")));

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer(); // Swagger dependency
            builder.Services.AddSwaggerGen();           // Swagger dependency

            var app = builder.Build();

            // Configure the HTTP request pipeline
            //if (app.Environment.IsDevelopment())
            //{
            app.UseSwagger();         // Shows swagger.json
            app.UseSwaggerUI();       // Shows Swagger UI
                                      //  }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
