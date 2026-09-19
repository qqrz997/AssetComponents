using UnityEngine;

namespace AssetComponents.Components.Notes
{
    [AddComponentMenu("Beat Saber/CustomNotes/Note Descriptor")]
    public class NoteDescriptor : MonoBehaviour
    {
        public string noteName = nameof(noteName);
        public string authorName = "Author";
        public Texture2D icon;
        public bool disableBaseNoteArrows;
    }
}