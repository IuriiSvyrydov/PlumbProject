using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.Concrete;

namespace ServiceLayer;

public static class DependencyInjection
{
    public static IServiceCollection AddServiceLayer(this IServiceCollection services)
    {
        services.RegisterCustomServices();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }

    public static IServiceCollection RegisterCustomServices(this IServiceCollection services)
    {
        var types = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x => x.IsClass && !x.IsAbstract && x.Name.EndsWith("Service"));

        foreach (var serviceType in types)
        {
            var iServiceType = serviceType.GetInterfaces().FirstOrDefault(x => x.Name == $"I{serviceType.Name}");
            if (iServiceType!=null)
            {
                services.AddScoped(iServiceType, serviceType);
            }
        }
        //services.AddScoped<IAboutService, AboutService>();
        //services.AddScoped<ICategoryService, CategoryService>();
        //services.AddScoped<IContactService, ContactService>();
        //services.AddScoped<IHomePageService, HomePageService>();
        //services.AddScoped<IPortfolioService, PortfolioService>();
        //services.AddScoped<IServiceService, ServiceService>();
        //services.AddScoped<ISocialMediaService, SocialMediaService>();
        //services.AddScoped<ITeamService, TeamService>();
        //services.AddScoped<ITestimonialService, TestimonialService>();
        return services;
    }
}