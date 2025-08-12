using BUI.Shared.Interfaces;

namespace BUI.Shared.Handlers;

public static class ClickHandler
{
    public static async Task HandleClickAsync(IClickable component)
    {
        if (component.Disabled) return;
        await component.OnClick.InvokeAsync();
    }
}
