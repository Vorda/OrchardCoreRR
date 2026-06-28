namespace SoftwareRR.FlowEnhancements;

public enum eGridSize { mob, tab, md, lg, xl }

internal static class FlowCssHelper
{
    public static string GetGridClass(eGridSize size, double percent)
    {
        int columns = (int)Math.Round((percent / 100.0) * 12);
        columns = Math.Min(12, Math.Max(1, columns));
        return $"{size}-{columns}";
    }

    public static string GetGridClass(eGridSize size, string percent)
    {
        return GetGridClass(size, Convert.ToDouble(percent));
    }
}
