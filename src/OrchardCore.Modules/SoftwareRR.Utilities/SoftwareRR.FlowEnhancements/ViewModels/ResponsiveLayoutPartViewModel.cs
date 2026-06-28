using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.ContentManagement;
using SoftwareRR.FlowEnhancements.Models;

namespace SoftwareRR.FlowEnhancements.ViewModels;

public class ResponsiveLayoutPartViewModel
{
    public string SizeMob { get; set; }
    public string SizeTab { get; set; }
    public string SizeMd { get; set; }
    public string SizeLg { get; set; }
    public string SizeXl { get; set; }
    public string Alignment { get; set; }

    [BindNever]
    public ContentItem ContentItem { get; set; }

    [BindNever]
    public ResponsiveLayoutPart ResponsiveLayoutPart { get; set; }
}
