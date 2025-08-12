using BUI.Shared.Enums;

namespace BUI.Theming.Interfaces;

public interface IButtonTheme
{
    string GetButtonClasses(Color color, Size size, bool disabled);
}
