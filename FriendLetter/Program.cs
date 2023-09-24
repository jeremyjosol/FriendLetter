using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace FriendLetter
{
  class Program
  {
    static void Main(string[] args)
    {
      // creates web application host
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

      builder.Services.AddControllersWithViews();
      // configures how we want our host to handle requests
      WebApplication app = builder.Build();
      // developer exception pages
      app.UseDeveloperExceptionPage();

      app.UseRouting();

      app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
      );
      // runs our host
      app.Run();
    }
  }
}