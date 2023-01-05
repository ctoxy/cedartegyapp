
using Core.Interfaces;
using Infrastructure;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using API.Helpers;
using Microsoft.AspNetCore.Mvc;
using API.Errors;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {public static IServiceCollection AddApplicationServices
        (
            this IServiceCollection services,
            IConfiguration config
        )
        {
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            //liaison db
            services.AddDbContext<StoreContext>(opt =>
            {
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext => 
                {
                    var errors = actionContext.ModelState
                        .Where(e => e.Value.Errors.Count > 0)
                        .SelectMany(x => x.Value.Errors)
                        .Select(x => x.ErrorMessage).ToArray();
                        
                    var errorResponse = new ApiValidationErrorResponse
                    {
                        Errors = errors
                    };

                    return new BadRequestObjectResult(errorResponse);
                };
            });
            // CORS
            services.AddCors(opt => {
                opt.AddPolicy("CorsPolicy", policy => {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200")
                });
            });
            // custom services
            // creation du Generic Repository utilisable pour le controleur pour tout les futur classe
            services.AddScoped(typeof(IGenericRepository<>), (typeof(GenericRepository<>)));
            // creation du PRODUCTREPOSITORY utilisable pour le controleur
            services.AddScoped<IProductRepository, ProductRepository>();
            //utilisation de automapper pour les reponses
            services.AddAutoMapper(typeof(MappingProfiles));
            
            return services;
        }
    }
}