using BlazorUI.Components.Shared.Enums;
using BlazorUI.Components.Shared.Extensions;
using Microsoft.AspNetCore.Components;

namespace BlazorUI.Components.Base;

public abstract class BBaseComponent : ComponentBase
{
    // ----------------------
    // Generic UI parameters
    // ----------------------
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public Color Color { get; set; } = Color.Default;
    [Parameter] public Size Size { get; set; } = Size.Medium;
    [Parameter] public string? Class { get; set; }

    // ----------------------
    // Lifecycle state
    // ----------------------
    protected bool IsRendered { get; private set; }
    protected bool IsLoading { get; set; }

    // ----------------------
    // Protected methods
    // ----------------------
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
            IsRendered = true;
    }

    protected void SetLoading(bool value)
    {
        IsLoading = value;
        StateHasChanged();
    }

    protected void SetDisabled(bool value)
    {
        Disabled = value;
        StateHasChanged();
    }

    // ----------------------
    // CSS helper
    // ----------------------
    protected string BuildCss(params string[] additionalClasses)
    {
        var baseClasses = new List<string>();

        if (Color != Color.Default)
            baseClasses.Add(Color.ToCss());

        if (Size != Size.Medium)
            baseClasses.Add(Size.ToCss());

        if (Disabled)
            baseClasses.Add("opacity-50 cursor-not-allowed");

        baseClasses.AddRange(additionalClasses);

        if (!string.IsNullOrWhiteSpace(Class))
            baseClasses.Add(Class);

        return string.Join(" ", baseClasses.Where(c => !string.IsNullOrWhiteSpace(c)));
    }

}
