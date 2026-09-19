using System;
using UnityEngine;
using UnityEngine.Events;

namespace AssetComponents.Components.Sabers
{
    [AddComponentMenu("Beat Saber/CustomSabers/Event Manager")]
    public class EventManager : MonoBehaviour
    {
        [Serializable] public class ComboChangedEvent : UnityEvent<int> { }
        [Serializable] public class AccuracyChangedEvent : UnityEvent<float> { }
        [Serializable] public class BoostColorsToggledEvent : UnityEvent<bool> { }

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
        public UnityEvent levelEnded;
        
        [Tooltip("Triggered when the player runs out of energy/life")]
        public UnityEvent levelFailed;

        [Tooltip("Triggered when one or more arcs start interacting with the saber")]
        public UnityEvent arcStartedInteracting;
        
        [Tooltip("Triggered when no more arcs are interacting with the saber")]
        public UnityEvent arcStoppedInteracting;

        [Tooltip("Triggered when environment boost colors toggle on or off")]
        public BoostColorsToggledEvent boostColorsToggled;
    }
}