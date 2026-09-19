using UnityEngine;

namespace AssetComponents.Components.Sabers
{
    [AddComponentMenu("Beat Saber/CustomSabers/Saber Descriptor")]
    public class SaberDescriptor : MonoBehaviour
    {
        public string saberName = nameof(saberName);
        public string authorName = nameof(authorName);
        public string description = nameof(description);
        public Texture2D coverImage;
    }
}
