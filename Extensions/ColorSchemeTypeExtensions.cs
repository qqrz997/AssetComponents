using AssetComponents.Models;

namespace AssetComponents.Extensions
{
    public static class ColorSchemeTypeExtensions
    {
        /// <summary>
        /// Get the opposite hand counterpart of the ColorSchemeType 
        /// </summary>
        public static ColorSchemeType GetMirrored(this ColorSchemeType t) => t switch
        {
            ColorSchemeType.LeftSaber => ColorSchemeType.RightSaber,
            ColorSchemeType.RightSaber => ColorSchemeType.LeftSaber,
            ColorSchemeType.EnvironmentColor0 => ColorSchemeType.EnvironmentColor1,
            ColorSchemeType.EnvironmentColor1 => ColorSchemeType.EnvironmentColor0,
            ColorSchemeType.EnvironmentColor0Boost => ColorSchemeType.EnvironmentColor1Boost,
            ColorSchemeType.EnvironmentColor1Boost => ColorSchemeType.EnvironmentColor0Boost,
            _ => t
        };
    }
}