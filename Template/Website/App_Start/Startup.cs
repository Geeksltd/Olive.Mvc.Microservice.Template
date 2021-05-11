namespace Website
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    using Olive.Aws;

    public abstract class Startup : FS.Shared.Website.Startup<Domain.ReferenceData, Domain.BackgroundTask, TaskManager>
    {
        protected Startup(IWebHostEnvironment env, IConfiguration config, ILoggerFactory factory) : base(env, config, factory)
        {
        }
        
        protected override SecretProviderType GetSecretsProvider() => SecretProviderType.SystemsManagerParameter;
    }
}
