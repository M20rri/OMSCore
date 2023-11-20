using log4net.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Application;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Persistence.Contexts;
using WebApi.Extensions;
using System;
using System.IO;
try
{
    var builder = WebApplication.CreateBuilder(args);
  
    //laod up Log4net configuraton
    builder.Logging.AddLog4Net();
    XmlConfigurator.Configure(new FileInfo("log4net.config"));

    builder.Services.AddApplicationLayer();
    builder.Services.AddPersistenceInfrastructure(builder.Configuration);
    builder.Services.AddSwaggerExtension();
    builder.Services.AddControllersExtension();

    // CORS
    builder.Services.AddCorsExtension();
    builder.Services.AddHealthChecks();
    //API Security
    builder.Services.AddJWTAuthentication(builder.Configuration);
    // API version
    builder.Services.AddApiVersioningExtension();
    // API explorer
    builder.Services.AddMvcCore()
        .AddApiExplorer();
    // API explorer version
    builder.Services.AddVersionedApiExplorerExtension();
    var app = builder.Build();
    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }

    using (var scope = app.Services.CreateScope())
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        // use context
        dbContext.Database.EnsureCreated();
    }



    app.UseHttpsRedirection();
    app.UseRouting();
    app.UseStaticFilesExtension();
    //Enable CORS
    app.UseCors("AllowAll");
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseSwaggerExtension();
    app.UseErrorHandlingMiddleware();
    app.MapControllers();
    app.Run();

    //Log.Information("Application Starting");

}
catch (Exception ex)
{
    //Log.Warning(ex, "An error occurred starting the application");
}
finally
{
    //Log.CloseAndFlush();
}
