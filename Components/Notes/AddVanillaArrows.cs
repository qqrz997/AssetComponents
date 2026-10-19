using AssetComponents.Models;
using UnityEngine;

namespace AssetComponents.Components.Notes
{
    public class AddVanillaArrows : MonoBehaviour
    {
        [Tooltip("Which color from a color scheme should be given")]
        public ColorSchemeType colorSchemeType;

        [Space]
        [Tooltip("Whether the arrows should always use the specified color")]
        public bool useOwnColor;
        public Color color;
    }
}