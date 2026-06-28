using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using SoftwareRR.FlowEnhancements.Drivers;
using SoftwareRR.FlowEnhancements.Models;

namespace SoftwareRR.FlowEnhancements;

[Feature("SoftwareRR.FlowEnhancements")]
public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddContentPart<ResponsiveLayoutPart>()
            .UseDisplayDriver<ResponsiveLayoutPartDisplayDriver>();

        services.AddDataMigration<Migrations>();
    }
}
