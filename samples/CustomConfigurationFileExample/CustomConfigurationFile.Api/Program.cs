using CustomConfigurationFile.Api.Models;

namespace CustomConfigurationFile.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Added Custom Settings file
            builder.Configuration
                .AddJsonFile("custom.settings.json", optional: false, reloadOnChange: true);

            // Add services to the container.
            builder.Services
                .Configure<ErrorMessages>(builder.Configuration.GetSection(ErrorMessages.SectionName));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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