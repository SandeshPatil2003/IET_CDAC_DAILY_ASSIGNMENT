namespace ConventionalRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            

            app.MapControllerRoute(

                name: "Route1",

                        pattern: "{controller=Home}/{action=Index}"

                );


            app.MapControllerRoute(

              name: "Route2",

                      pattern: "{controller=Controller1}/{action=Index2}"

              );

            









            app.Run();
        }
    }
}
