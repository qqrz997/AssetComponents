using AssetComponents.Editor;
using UnityEngine;

namespace AssetComponents.Components.Sabers
{
    [AddComponentMenu("Beat Saber/CustomSabers/Saber Descriptor")]
    public class SaberDescriptor : MonoBehaviour
    {
        public string saberName = nameof(saberName);
        public string authorName = nameof(authorName);
        public Texture2D coverImage;

        [Space]
        
        public GameObject leftSaber;
        
        [OptionalProperty]
        public GameObject rightSaber;
    }
}
