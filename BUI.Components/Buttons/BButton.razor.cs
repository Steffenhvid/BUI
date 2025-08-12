using BUI.Components.Base;
using BUI.Shared.Handlers;
using BUI.Shared.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BUI.Components.Buttons;

public partial class BButton : BComponentBase, IClickable
{
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter] public EventCallback OnClick { get; set; }

    protected string CssClass => BuildCss("btn");

    public async Task HandleClickAsync()
    {
        await ClickHandler.HandleClickAsync(this);
    }
}
