namespace WebApplication1.Extensions
{
    public class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder => builder



            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

        });
    }
}
