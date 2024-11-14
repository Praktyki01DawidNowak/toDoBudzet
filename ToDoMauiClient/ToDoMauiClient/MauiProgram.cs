﻿using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using ToDoMauiClient.DataServices;

namespace ToDoMauiClient
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

    		builder.Services.AddSingleton<IRestDataService, RestDataService>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.TryAddTransient<ManageToDoPage>();

            return builder.Build();
        }
    }
}