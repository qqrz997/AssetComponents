using SaberComponents.Models;
using UnityEngine;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/Saber Components/CustomTrail")]
    public class CustomTrail : MonoBehaviour
    {
        public Transform pointStart;
        public Transform pointEnd;
        public Material trailMaterial;
        
        [Space]
        [Range(0, 1)]
        public float length = 0.4f;
        
        [Space]
        public ColorType colorType = ColorType.CustomColor;
        public Color trailColor = Color.white;
        public Color multiplierColor = Color.white;
    }
}