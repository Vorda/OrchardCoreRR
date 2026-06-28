using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.Views;
using SoftwareRR.FlowEnhancements.Models;
using SoftwareRR.FlowEnhancements.ViewModels;

namespace SoftwareRR.FlowEnhancements.Drivers;

public sealed class ResponsiveLayoutPartDisplayDriver : ContentPartDisplayDriver<ResponsiveLayoutPart>
{
    public override IDisplayResult Edit(ResponsiveLayoutPart part, BuildPartEditorContext context)
    {
        return Initialize<ResponsiveLayoutPartViewModel>(GetEditorShapeType(context), m =>
        {
            m.ResponsiveLayoutPart = part;
            m.ContentItem = part.ContentItem;

            m.SizeMob = part.SizeMob;
            m.SizeTab = part.SizeTab;
            m.SizeMd = part.SizeMd;
            m.SizeLg = part.SizeLg;
            m.SizeXl = string.IsNullOrEmpty(part.SizeXl) ? "100" : part.SizeXl;
            m.Alignment = string.IsNullOrEmpty(part.Alignment) ? "Inherit" : part.Alignment;
        });
    }

    public override async Task<IDisplayResult> UpdateAsync(ResponsiveLayoutPart model, UpdatePartEditorContext context)
    {
        var vm = new ResponsiveLayoutPartViewModel();

        await context.Updater.TryUpdateModelAsync(vm, Prefix,
            x => x.SizeMob,
            x => x.SizeTab,
            x => x.SizeMd,
            x => x.SizeLg,
            x => x.SizeXl,
            x => x.Alignment);

        model.SizeMob = vm.SizeMob;
        model.SizeTab = vm.SizeTab;
        model.SizeMd = vm.SizeMd;
        model.SizeLg = vm.SizeLg;
        model.SizeXl = vm.SizeXl;
        model.Alignment = vm.Alignment;

        return Edit(model, context);
    }
}
