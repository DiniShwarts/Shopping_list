using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MyMinimalApi.Repositories;
using MyMinimalApi.Services;
using MyMinimalApi.Data; // הוספת ה-using ל-Data (לפי הצורך)

namespace MyMinimalApi.Configuration
{
   public static class DIConfig
   {
       public static void AddCustomServices(this IServiceCollection services)
       {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer("YourConnectionStringHere"));

            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IItemService, ItemService>();
       }
   }

}

