using System.Text.Json;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.ProductBrands.Any())
                {
                    var brandsData = 
                        File.ReadAllText("../Infrastructure/Data/SeedData/brands.json");
                    
                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                    foreach (var item in brands)
                    {
                        context.ProductBrands.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.ProductTypes.Any())
                {
                    var typesData = 
                        File.ReadAllText("../Infrastructure/Data/SeedData/types.json");
                    
                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    foreach (var item in types)
                    {
                        context.ProductTypes.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.Products.Any())
                {
                    var productsData = 
                        File.ReadAllText("../Infrastructure/Data/SeedData/products.json");
                    
                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    foreach (var item in products)
                    {
                        context.Products.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.VnRetrofitTypes.Any())
                {
                    var vnRetrofitTypesData = 
                        File.ReadAllText("../Infrastructure/Data/SeedData/VnRetrofitTypes.json");
                    
                    var types = JsonSerializer.Deserialize<List<VnRetrofitType>>(vnRetrofitTypesData);

                    foreach (var item in types)
                    {
                        context.VnRetrofitTypes.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                if(!context.Advs.Any())
                {
                    var advsData = 
                        File.ReadAllText("../Infrastructure/Data/SeedData/advs.json");
                    
                    var advs = JsonSerializer.Deserialize<List<Adv>>(advsData);

                    foreach (var item in advs)
                    {
                        context.Advs.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}