using UnityEngine;

namespace AssetComponents.Components.Notes
{
    [AddComponentMenu("Beat Saber/CustomNotes/Note Set")]
    public class NoteSet : MonoBehaviour
    {
        public GameObject noteArrow;
        public GameObject noteDot;

        [Space]
        public GameObject chainArrow;
        public GameObject chainDot;
        public GameObject chainSegment;
    }
}