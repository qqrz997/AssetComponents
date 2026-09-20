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
        public NoteSet leftNotes;
        [PropertyLabel("Right Notes (Optional)")]
        public NoteSet rightNotes;
            
        [Space]
        public bool disableBaseNoteArrows;
    }
}