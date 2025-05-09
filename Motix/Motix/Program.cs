using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Motix.API.Infrastructure.Context;


namespace Motix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            // Swagger/OpenAPI configuration
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Motix API",
                    Description = "Sprint 1 - " + DateTime.Now.Year,
                    Contact = new OpenApiContact()
                    {
                        Email = "nicolasbarutti2003@gmail.com",
                        Name = "Nicolas Barutti"
                    }
                });
            });

            // Add DbContext with Oracle configuration
            builder.Services.AddDbContext<MotixContext>(options =>
            {
                options.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
            });

            var app = builder.Build();

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
        }
    }
}
