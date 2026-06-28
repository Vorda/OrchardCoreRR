using OrchardCore.ContentManagement;

namespace SoftwareRR.FlowEnhancements.Models;

public class ResponsiveLayoutPart : ContentPart
{
    public string SizeMob { get; set; }
    public string SizeTab { get; set; }
    public string SizeMd { get; set; }
    public string SizeLg { get; set; }
    public string SizeXl { get; set; } = "100";
    public string Alignment { get; set; } = "Inherit";
}
