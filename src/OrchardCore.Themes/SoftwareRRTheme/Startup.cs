using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;

namespace SoftwareRRTheme;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddResourceConfiguration<ResourceManagementOptionsConfiguration>();
    }
}
