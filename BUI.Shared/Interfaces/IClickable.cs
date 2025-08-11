using Microsoft.AspNetCore.Components;

namespace BlazorUI.Components.Shared.Interfaces;

public interface IClickable
{
    EventCallback OnClick { get; }
    bool Disabled { get; }
    Task HandleClickAsync();
}
