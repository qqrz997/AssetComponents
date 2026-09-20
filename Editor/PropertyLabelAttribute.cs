using UnityEngine;

namespace AssetComponents.Editor
{
    public class PropertyLabelAttribute : PropertyAttribute
    {
        private readonly string label;

        public PropertyLabelAttribute(string label)
        {
            this.label = label;
        }

        public string Label => label;
    }
}