using BUI.Shared.Enums;
using BUI.Theming.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BUI.Components.Base;

public abstract class BComponentBase : ComponentBase
{
    [Inject] protected IThemeProvider Theme { get; private set; } = default!;

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
    protected virtual string BuildCss(params string[] classes) =>
           string.Join(" ", classes.Where(c => !string.IsNullOrWhiteSpace(c)));

}
