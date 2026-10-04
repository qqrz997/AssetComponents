using AssetComponents.Extensions;
using AssetComponents.Models;
using UnityEngine;

#pragma warning disable CS0649

namespace AssetComponents.Components
{
    [AddComponentMenu("Beat Saber/AssetComponents/MaterialColorer")]
    [RequireComponent(typeof(MeshRenderer))]
    public class MaterialColorer : MonoBehaviour, IBeatSaberColorer
    {
        private MaterialPropertyBlock materialPropertyBlock;
        
        [SerializeField, HideInInspector]
        private MeshRenderer meshRenderer;
        
        [Space]
        
        [SerializeField]
        [Tooltip("Array index of the material from the Mesh Renderer should be colored")]
        private int materialIndex;
        
        [SerializeField]
        [Tooltip("The name of the target color property of the material")]
        private string propertyName = "_Color";
        
        [SerializeField]
        [Tooltip("Which color from a color scheme should be given")]
        private ColorSchemeType colorSchemeType;
        
        [SerializeField]
        [Tooltip("When Color Type is set to an environment color, toggle between normal and boost colors on boost event")]
        private bool useColorBoostEvents;
        
        [SerializeField]
        [Tooltip("The color given to the property is always multiplied by the multiplier color; white has no effect")]
        private Color multiplierColor = Color.white;

        public ColorSchemeType ColorSchemeType => colorSchemeType;
        public bool UseColorBoostEvents => useColorBoostEvents;

        private void Awake()
        {
            meshRenderer = GetComponent<MeshRenderer>();
        }

        public void MirrorColorSchemeType()
        {
            colorSchemeType = colorSchemeType.GetMirrored();
        }

        public void SetColor(Color color)
        {
            if (!meshRenderer) return;
            materialPropertyBlock ??= new();
            materialPropertyBlock.SetColor(propertyName, color * multiplierColor);
            meshRenderer.SetPropertyBlock(materialPropertyBlock, materialIndex);
        }
    }
}
