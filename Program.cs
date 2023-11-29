
using System.Diagnostics;
using HarryPotterAPI.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HarryPotterAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("HPConnection");

            builder.Services.AddDbContext<HarryPotterContext>(opts => opts.UseMySql(connectionString,
                 ServerVersion.AutoDetect(connectionString)));

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddControllers();

            builder.Services.AddControllers().AddNewtonsoftJson(opts => {opts.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;});



            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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