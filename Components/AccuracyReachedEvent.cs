using UnityEngine;
using UnityEngine.Events;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/SaberComponents/AccuracyReachedEvent")]
    [RequireComponent(typeof(EventManager))]
    public class AccuracyReachedEvent : MonoBehaviour
    {
        public float target = 1f;
        public UnityEvent onAccuracyReachTarget;
        public UnityEvent onAccuracyHigherThanTarget;
        public UnityEvent onAccuracyLowerThanTarget;

        private EventManager eventManager;
        private float prevAccuracy;

        private void OnEnable()
        {
            if (eventManager == null) eventManager = GetComponent<EventManager>();
            eventManager.OnAccuracyChanged.AddListener(OnAccuracyReached);
            prevAccuracy = 1f;
        }

        private void OnDisable()
        {
            eventManager.OnAccuracyChanged.RemoveListener(OnAccuracyReached);
        }

        private void OnAccuracyReached(float accuracy)
        {
            if ((prevAccuracy > target && accuracy < target) || (prevAccuracy < target && accuracy > target))
            {
                onAccuracyReachTarget.Invoke();
            }
            if (prevAccuracy < target && accuracy > target)
            {
                onAccuracyHigherThanTarget.Invoke();
            }
            if (prevAccuracy > target && accuracy < target)
            {
                onAccuracyLowerThanTarget.Invoke();
            }
            prevAccuracy = accuracy;
        }
    }
}