using BlazorUI.Components.Shared.Enums;

namespace BlazorUI.Components.Shared.Extensions;

public static class ColorExtensions
{
    public static string ToCss(this Color color) => color switch
    {
        Color.Primary => "btn-primary",
        Color.Secondary => "btn-secondary",
        Color.Danger => "btn-danger",
        _ => "btn-default"
    };
}
