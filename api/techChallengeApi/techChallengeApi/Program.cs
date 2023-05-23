using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using techChallengeApi.Data;
using techChallengeApi.Model;
using techChallengeApi.Repositories;
using techChallengeApi.Repositories.Interfaces;

namespace techChallengeApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "MyPolicy",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000/", "https://localhost:3000/")
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin();
                        
                    });
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<ISeller, SellerRepositories>();
            builder.Services.AddScoped<IGeneralSales, GeneralSalesRepositories>();
            builder.Services.AddScoped<IProducts, ProductsRepositories>();
            builder.Services.AddScoped<IVariety, VarietyRepositories>();

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

            app.UseCors("MyPolicy");
            app.Run();
        }
    }
}