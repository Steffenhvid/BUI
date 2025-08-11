using BlazorUI.Components.Base;
using BlazorUI.Components.Shared.Handlers;
using BlazorUI.Components.Shared.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorUI.Components.Components.Buttons;

public partial class BButton : BBaseComponent, IClickable
{
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter] public EventCallback OnClick { get; set; }

    protected string CssClass => BuildCss("btn");

    public async Task HandleClickAsync()
    {
        await ClickHandler.HandleClickAsync(this);
    }
}
