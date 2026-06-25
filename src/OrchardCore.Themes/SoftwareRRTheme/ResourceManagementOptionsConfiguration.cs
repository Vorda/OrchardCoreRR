using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace SoftwareRRTheme;

public sealed class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
{
    private static readonly ResourceManifest _manifest;

    static ResourceManagementOptionsConfiguration()
    {
        _manifest = new ResourceManifest();

        _manifest
            .DefineStyle("SoftwareRRTheme-plugins")
            .SetUrl("~/SoftwareRRTheme/css/vendor.min.css", "~/SoftwareRRTheme/css/vendor.css")
            .SetVersion("0.0.1");

        _manifest
            .DefineStyle("SoftwareRRTheme")
            .SetUrl("~/SoftwareRRTheme/css/styles.min.css", "~/SoftwareRRTheme/css/styles.css")
            .SetVersion("0.0.1");

        _manifest
           .DefineScript("SoftwareRRTheme-plugins")
           .SetUrl("~/SoftwareRRTheme/js/plugins.js", "~/SoftwareRRTheme/js/plugins.js")
           .SetVersion("0.0.1");

        _manifest
            .DefineScript("SoftwareRRTheme")
            .SetDependencies("SoftwareRRTheme-plugins")
            .SetUrl("~/SoftwareRRTheme/js/main.min.js", "~/SoftwareRRTheme/js/main.js")
            .SetVersion("0.0.1");
    }

    public void Configure(ResourceManagementOptions options)
    {
        options.ResourceManifests.Add(_manifest);
    }
}
