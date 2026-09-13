// ReSharper disable InconsistentNaming CheckNamespace
using UnityEngine;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/Saber Components/SaberDescriptor")]
    public class SaberDescriptor : MonoBehaviour
    {
        public string SaberName = nameof(SaberName);
        public string AuthorName = nameof(AuthorName);
        public string Description = nameof(Description);
        public Sprite CoverImage;
    }
}
