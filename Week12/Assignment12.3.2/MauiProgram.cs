using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Assignment12._3._2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddDbContext<BookContext>(options => options.UseSqlite($"Data Source=Books.db"));
            using (var scope = builder.Services.BuildServiceProvider().CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<BookContext>();
                db.Database.EnsureCreated();
            }
            builder.Services.AddSingleton<BooksViewModel>();
            return builder.Build();
        }
    }
}
