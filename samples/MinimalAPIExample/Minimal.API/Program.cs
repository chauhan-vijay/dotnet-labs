namespace Minimal.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.WebHost.ConfigureKestrel(_ => _.AddServerHeader = false);

            // Add services to the container.

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.Map("/", () => "Hello World!");

            app.Run();
        }
    }
}