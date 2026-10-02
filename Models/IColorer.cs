using UnityEngine;

namespace AssetComponents.Models
{
    public interface IColorer
    {
        Material Material { get; }
        int MaterialIndex { get; }
        MaterialPropertyBlock MaterialPropertyBlock { get; }
        
        string PropertyName { get; }
        ColorSchemeType ColorSchemeType { get; }
        bool UseColorBoostEvents { get; }
        Color MultiplierColor { get; }

        /// <summary>
        /// Changes this instance's ColorSchemeType to that of the opposite hand
        /// </summary>
        void MirrorColorType();
    }
}