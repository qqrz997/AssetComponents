using UnityEngine;

namespace AssetComponents.Components.Notes
{
    public class NoteDescriptor : MonoBehaviour
    {
        public string noteName = nameof(noteName);
        public string authorName = "Author";
        public Texture2D icon;
        public bool disableBaseNoteArrows;
    }
}