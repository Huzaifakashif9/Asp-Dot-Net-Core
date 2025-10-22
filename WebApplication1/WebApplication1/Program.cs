internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMvc();
        var app = builder.Build();

        //app.MapGet("/", () => "Hello World!");
        //app.MapGet("/about", () => "Hello about!");
        //app.MapGet("/contact", () => "Hello contact");

        //app.MapControllerRoute(
        //    name: "default",
        //    pattern: "{controller=Home}/{action=Index}");
        app.MapControllers();       

        app.Run();
    }
}