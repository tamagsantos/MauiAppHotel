using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "Pacifico-Regular");
                    fonts.AddFont("SourGummy_Expanded-Black.ttf", "SourGummyExpandedBlack");
                    fonts.AddFont("SourGummy_Expanded-BlackItalic.ttf", "SourGummyExBlackItalic");
                    fonts.AddFont("SourGummy_Expanded-Bold.ttf", "SourGummyExBold");
                    fonts.AddFont("SourGummy_Expanded-BoldItalic.ttf", "SourGummyExBoldItalic");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
