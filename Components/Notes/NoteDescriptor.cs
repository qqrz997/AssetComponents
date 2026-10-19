using AssetComponents.Editor;
using UnityEngine;

namespace AssetComponents.Components.Notes
{
    [AddComponentMenu("Beat Saber/CustomNotes/Note Descriptor")]
    public class NoteDescriptor : MonoBehaviour
    {
        public string noteName = nameof(noteName);
        public string authorName = "Author";
        public Texture2D icon;
        
        [Space]
        
        [Header("Left Notes")]
        public GameObject leftNoteArrow;
        [OptionalProperty] public GameObject leftNoteDot;
        [OptionalProperty] public GameObject leftChainArrow;
        [OptionalProperty] public GameObject leftChainDot;
        [OptionalProperty] public GameObject leftChainSegment;
        
        [Header("Right Notes")]
        [OptionalProperty] public GameObject rightNoteArrow;
        [OptionalProperty] public GameObject rightNoteDot;
        [OptionalProperty] public GameObject rightChainArrow;
        [OptionalProperty] public GameObject rightChainDot;
        [OptionalProperty] public GameObject rightChainSegment;
        
        [OptionalProperty] public GameObject bomb;
    }
}