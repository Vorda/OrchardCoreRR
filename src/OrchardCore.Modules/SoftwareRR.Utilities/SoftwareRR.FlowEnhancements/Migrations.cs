using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentFields.Settings;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using OrchardCore.Flows.Models;
using SoftwareRR.FlowEnhancements.Models;

namespace SoftwareRR.FlowEnhancements;

public sealed class Migrations : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;
    public Migrations(IContentDefinitionManager contentDefinitionManager)
    {
        _contentDefinitionManager = contentDefinitionManager;
    }

    public async Task<int> CreateAsync()
    {
        await _contentDefinitionManager.AlterTypeDefinitionAsync("ContentBlock", t => t
            .WithDisplayName("Content Block")
            .Stereotype("Widget")
            .Draftable(true)
            .Versionable(true)
            .Securable(true)
            .WithPart<FlowPart>(p => p.WithSettings(new FlowPartSettings { ContainedContentTypes = ["Heading", "Paragraph"]}))
            .WithPart<ResponsiveLayoutPart>());

        await _contentDefinitionManager.AlterPartDefinitionAsync("Row", builder => builder
            .WithField<TextField>("CustomClasses", f => f
                .WithDisplayName("Custom CSS classes")
                .WithSettings(new TextFieldSettings { Hint = "Optional extra classes, e.g. 'bg-light highlight'" }))
        );

        await _contentDefinitionManager.AlterTypeDefinitionAsync("Row", t => t
            .WithDisplayName("Row")
            .Stereotype("Widget")
            .Draftable(true)
            .Versionable(true)
            .Securable(true)
            .WithPart("Row")
            .WithPart<FlowPart>(p => p.WithSettings(new FlowPartSettings() { ContainedContentTypes = ["ContentBlock"] })));

        return 1;
    }
}
