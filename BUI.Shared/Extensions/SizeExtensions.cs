using BlazorUI.Components.Shared.Enums;

namespace BlazorUI.Components.Shared.Extensions;

public static class SizeExtensions
{
    public static string ToCss(this Size size) => size switch
    {
        Size.Tiny => "tn",
        Size.Small => "sm",
        Size.Large => "lg",
        Size.ExtraLarge => "xl",
        _ => "md"
    };
}
