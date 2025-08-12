namespace BUI.Theming.Interfaces;

public interface IThemeProvider
{
    IButtonTheme Buttons { get; }
    // Later: ITabsTheme, ICardTheme, etc.
}
