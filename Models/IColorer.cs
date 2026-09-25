using UnityEngine;

namespace AssetComponents.Models
{
    public interface IColorer
    {
        public Material Material { get; }
        public MaterialPropertyBlock MaterialPropertyBlock { get; }
        
        public string PropertyName { get; }
        public ColorSchemeType ColorSchemeType { get; }
        public bool UseColorBoostEvents { get; }
        public Color MultiplierColor { get; }
    }
}