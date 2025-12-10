using AITech.Business.Services.AboutItemServices;
using AITech.Business.Services.AboutServices;
using AITech.Business.Services.BannerServices;
using AITech.Business.Services.CategoryServices;
using AITech.Business.Services.ChooseServices;
using AITech.Business.Services.FAQServices;
using AITech.Business.Services.FeatureServices;
using AITech.Business.Services.ProjectServices;
using AITech.Business.Services.SocialServices;
using AITech.Business.Services.TestimonialServices;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.Business.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
			services.AddScoped<IAboutService, AboutService>();
			services.AddScoped<IAboutItemService, AboutItemService>();
			services.AddScoped<IBannerService, BannerService>();
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IChooseService, ChooseService>();
			services.AddScoped<IFAQService, FAQService>();
			services.AddScoped<IFeatureService, FeatureService>();
			services.AddScoped<IProjectService, ProjectService>();
			services.AddScoped<ISocialService, SocialService>();
			services.AddScoped<ITestimonialService, TestimonialService>();
		}
    }
}
