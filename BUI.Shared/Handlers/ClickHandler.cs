using BlazorUI.Components.Shared.Interfaces;

namespace BlazorUI.Components.Shared.Handlers;

public static class ClickHandler
{
    public static async Task HandleClickAsync(IClickable component)
    {
        if (component.Disabled) return;
        await component.OnClick.InvokeAsync();
    }
}
