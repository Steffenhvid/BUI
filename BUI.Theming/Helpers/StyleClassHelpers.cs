using Microsoft.Extensions.Logging;

namespace BUI.Theming.Helpers
{
    public static class StyleClassHelpers
    {
        public static string LogAndReturnEmpty(string property, ILogger logger)
        {
            logger.LogWarning("Enum {Property} is not defined.", property);
            return string.Empty;
        }
    }
}
