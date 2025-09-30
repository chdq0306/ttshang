using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ttshang.Blazor.Components;
using ttshang.Blazor.Client;
using Volo.Abp;
using Volo.Abp.AspNetCore.Components.WebAssembly.WebApp;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.Libs;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming.Bundling;
using Volo.Abp.AspNetCore.Components.WebAssembly.LeptonXLiteTheme.Bundling;

namespace ttshang.Blazor;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyLeptonXLiteThemeBundlingModule),
    typeof(AbpAspNetCoreMvcUiBundlingModule)
)]
public class ttshangBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //https://github.com/dotnet/aspnetcore/issues/52530
        Configure<RouteOptions>(options =>
        {
            options.SuppressCheckForUnhandledSecurityMetadata = true;
        });

        // Add services to the container.
        context.Services.AddRazorComponents()
            .AddInteractiveWebAssemblyComponents();

        Configure<AbpMvcLibsOptions>(options =>
        {
            options.CheckLibs = false;
        });

        Configure<AbpBundlingOptions>(options =>
        {
            var globalStyles = options.StyleBundles.Get(BlazorWebAssemblyStandardBundles.Styles.Global);
            globalStyles.AddContributors(typeof(ttshangStyleBundleContributor));

            var globalScripts = options.ScriptBundles.Get(BlazorWebAssemblyStandardBundles.Scripts.Global);
            globalScripts.AddContributors(typeof(ttshangScriptBundleContributor));

        });
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var env = context.GetEnvironment();
        var app = context.GetApplicationBuilder();

        // Configure the HTTP request pipeline.
        if (env.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
        }
        else
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.MapAbpStaticAssets();
        app.UseAntiforgery();

        app.UseConfiguredEndpoints(builder =>
        {
            builder.MapRazorComponents<App>()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(WebAppAdditionalAssembliesHelper.GetAssemblies<ttshangBlazorClientModule>());
        });
    }
}
