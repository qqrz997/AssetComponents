using SaberComponents.Models;
using UnityEngine;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/SaberComponents/CustomTrail")]
    public class CustomTrail : MonoBehaviour
    {
        public Transform top;
        public Transform bottom;
        
        [Space]
        public Material material;
        
        [Space]
        [Range(0, 1), Tooltip("Duration of the furthest section of the trail in seconds")]
        public float length = 0.4f;
        
        [Space]
        [Tooltip("Which color from a color scheme the trail should use")]
        public ColorType colorType;
        [Tooltip("When Color Type is set to an environment color, toggle between normal and boost colors on boost event")]
        public bool useColorBoostEvents;

        [Space] 
        public bool useTrailColor;
        public Color trailColor = Color.white;
        [Tooltip("The color given to the trail is always multiplied by the multiplier color; white has no effect")]
        public Color multiplierColor = Color.white;
    }
}