using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using System.Globalization;

var serviceProvider = new ServiceCollection()
    .AddLogging()
    .AddLocalization(options => options.ResourcesPath = "Resources")
    .Configure<RequestLocalizationOptions>(options =>
        {
            var supportedCultures = new[]
            {
                new CultureInfo("en-US"),
                new CultureInfo("ro-RO")
            };

            options.DefaultRequestCulture = new RequestCulture("en-US", "en-US");
            options.SupportedCultures = supportedCultures;
            options.SupportedUICultures = supportedCultures;
        })
    .BuildServiceProvider();

var localizer = serviceProvider.GetService<IStringLocalizer<Program>>();
string message = localizer!.GetString("Hello world!");

Console.WriteLine(message);
