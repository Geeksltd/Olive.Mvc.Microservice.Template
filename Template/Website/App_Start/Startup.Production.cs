using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Olive;
using Olive.Aws;
using Olive.Mvc;
using Olive.PassiveBackgroundTasks;
using System.Threading.Tasks;

namespace Website
{
    public class StartupProduction : Startup
    {
        public StartupProduction(IWebHostEnvironment env, IConfiguration config, ILoggerFactory factory) : base(env, config, factory)
        {

        }

        protected override void ConfigureRequestHandlers(IApplicationBuilder app)
        {
            app.IgnorePerformance("/olive-trigger-tasks");
            app.IgnorePerformance("/api/legacy/all");

            base.ConfigureRequestHandlers(app);
        }

        protected override SecretProviderType GetSecretsProvider() => SecretProviderType.SystemsManagerParameter;
    }
}

