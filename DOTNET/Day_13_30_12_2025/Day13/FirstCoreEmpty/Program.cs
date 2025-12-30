namespace FirstCoreEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "359986" + " \n JOHN CENA");

            app.MapPost("/",() => 
                " POST JOHN CENA");

            app.MapPut("/", () => " PUT JOHN CENA");

            app.MapDelete("/", () => " DELETE JOHN CENA");

            app.Run();
        }
    }
}
