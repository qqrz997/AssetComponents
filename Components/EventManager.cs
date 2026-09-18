
using System;
using UnityEngine;
using UnityEngine.Events;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/SaberComponents/EventManager")]
    public class EventManager : MonoBehaviour
    {
        [Serializable] public class ComboChangedEvent : UnityEvent<int> { }
        [Serializable] public class AccuracyChangedEvent : UnityEvent<float> { }

        [Tooltip("Triggered when a note is cut with the correct saber in the correct direction")]
        public UnityEvent noteCut;
        
        [Tooltip("Triggered when combo changes, returns new combo")]
        public ComboChangedEvent comboChanged = new();
        
        [Tooltip("Triggered when accuracy changes, returns percentage accuracy between 0 and 1")]
        public AccuracyChangedEvent accuracyChanged = new();
        
        [Tooltip("Triggered when combo is broken")]
        public UnityEvent comboBroken;
        
        [Tooltip("Triggered when score multiplier increases")]
        public UnityEvent multiplierUp;
        
        [Tooltip("Triggered when both sabers intersect")]
        public UnityEvent saberStartColliding;
        
        [Tooltip("Triggered when both sabers stop intersecting")]
        public UnityEvent saberStopColliding;
        
        [Tooltip("Triggered as soon as the song starts")]
        public UnityEvent levelStarted;
        
        [Tooltip("Triggered when the last note of the map reaches the player")]
        public UnityEvent onLevelEnded;
        
        [Tooltip("Triggered when the player runs out of energy/life")]
        public UnityEvent levelFailed;
    }
}