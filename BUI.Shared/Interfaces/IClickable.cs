using Microsoft.AspNetCore.Components;

namespace BUI.Shared.Interfaces;

public interface IClickable
{
    EventCallback OnClick { get; }
    bool Disabled { get; }
    Task HandleClickAsync();
}
