using API.Extensions;
using API.Middleware;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// appel de ApplictionServiceExtension
builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

// middleware de gestions des erreur du serveur position avant toute"
app.UseMiddleware<ExeptionMiddleware>();

//permet accés a swagger en prod et dev
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));



// place importante pour capter l'ensemble des erreurs passé au serveur avant envoi client
app.UseStatusCodePagesWithReExecute("/errors/{0}");
// position importante ne pas deplacer accorder a la vue angular
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

//lecture des fichiers statique tel que image de wwwroot
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

// permet a chaque de démarrage de récréer la base au complet with seed
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var loggerFactory = services.GetRequiredService<ILoggerFactory>();

try
{
    var context = services.GetRequiredService<StoreContext>();
    await context.Database.MigrateAsync();
    await StoreContextSeed.SeedAsync(context, loggerFactory);
}
catch (Exception ex)
{
    var logger = services.GetService<ILogger<Program>>();
    logger.LogError(ex,"un soucis durant la migration");   
    
}


app.Run();
