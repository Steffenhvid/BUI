using BUI.Shared.Enums;
using BUI.Theming.Helpers;
using BUI.Theming.Interfaces;
using Microsoft.Extensions.Logging;

namespace BUI.Theming.Bulma
{
    public class BulmaButtonTheme(ILogger<BulmaButtonTheme> logger) : IButtonTheme
    {
        public string GetButtonClasses(Color color, Size size, bool disabled)
        {
            var classes = new List<string> { "button" };

            classes.Add(color switch
            {
                Color.Primary => "is-primary",
                Color.Secondary => "is-link",
                Color.Success => "is-success",
                Color.Danger => "is-danger",
                _ => StyleClassHelpers.LogAndReturnEmpty(nameof(color), logger)
            });

            classes.Add(size switch
            {
                Size.Small => "is-small",
                Size.Normal => "is-normal",
                Size.Medium => "is-medium",
                Size.Large => "is-large",
                _ => StyleClassHelpers.LogAndReturnEmpty(nameof(size), logger)
            });

            if (disabled) classes.Add("is-static");

            return string.Join(" ", classes.Where(c => !string.IsNullOrWhiteSpace(c)));
        }
    }
}
