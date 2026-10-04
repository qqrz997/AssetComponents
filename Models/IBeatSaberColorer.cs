namespace AssetComponents.Models
{
    public interface IBeatSaberColorer
    {
        ColorSchemeType ColorSchemeType { get; }
        bool UseColorBoostEvents { get; }
        
        /// <summary>
        /// Changes this instance's ColorSchemeType to that of the opposite hand
        /// </summary>
        void MirrorColorSchemeType();
    }
}
