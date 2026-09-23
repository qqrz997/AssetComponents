using UnityEngine;

namespace AssetComponents.Models
{
    internal interface IColorer
    {
        public Material[] Materials { get; }
        public MaterialPropertyBlock MaterialPropertyBlock { get; }
        
        public string PropertyName { get; }
        public ColorSchemeType ColorSchemeType { get; }
        public bool UseColorBoostEvents { get; }
        public Color MultiplierColor { get; }
    }
}