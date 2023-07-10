using Arkham.Application;
using Arkham.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;

namespace Arkham.HttpApi.Host;

[DependsOn(
    typeof(ArkhamApplicationModule),
    typeof(ArkhamEntityFrameworkCoreModule),
    typeof(ArkhamHttpApiModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpSwashbuckleModule),
    typeof(AbpAutofacModule)
)]
public class ArkhamHttpApiHostModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        var configuration = context.Services.GetConfiguration();
        var hostingEnvironment = context.Services.GetHostingEnvironment();

        Configure<AbpAspNetCoreMvcOptions>(options =>
            options.ConventionalControllers.Create(typeof(ArkhamHttpApiModule).Assembly)
            );
        _ = context.Services.AddAbpSwaggerGen(
               options =>
               {
                   options.SwaggerDoc("v1", new OpenApiInfo { Title = "BookStore API", Version = "v1" });
                   options.DocInclusionPredicate((docName, description) => true);
                   options.CustomSchemaIds(schemaIdSelector: type => type.FullName);
               });
        if (hostingEnvironment.IsDevelopment())
        {
            Console.WriteLine("this is development environment");
        }
        else if (hostingEnvironment.IsProduction())
        {
            Console.WriteLine("this is production environment");
        }
    }
    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        base.OnApplicationInitialization(context);
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        // Configure the HTTP request pipeline.
        if (env.IsDevelopment())
        {
            _ = app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            _ = app.UseHsts();
            _ = app.UseSwagger();
            _ = app.UseSwaggerUI();
        }

        _ = app.UseHttpsRedirection();
        _ = app.UseStaticFiles();
        _ = app.UseRouting();
        _ = app.UseConfiguredEndpoints();
    }
}
