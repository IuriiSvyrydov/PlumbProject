using System.Reflection;
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
        services.AddScoped<IAboutService, AboutService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IContactService, ContactService>();
        services.AddScoped<IHomePageService, HomePageService>();
        services.AddScoped<IPortfolioService, PortfolioService>();
        services.AddScoped<IServiceService, ServiceService>();
        services.AddScoped<ISocialMediaService, SocialMediaService>();
        services.AddScoped<ITeamService, TeamService>();
        services.AddScoped<ITestimonialService, TestimonialService>();
        return services;
    }
}