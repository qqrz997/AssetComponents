using UnityEngine;
using UnityEngine.Events;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/Saber Components/AccuracyReachedEvent")]
    public class AccuracyReachedEvent : EventFilterBehaviour
    {
        public float target = 1f;
        public UnityEvent onAccuracyReachTarget;
        public UnityEvent onAccuracyHigherThanTarget;
        public UnityEvent onAccuracyLowerThanTarget;
    
        private float prevAccuracy;

        private void OnEnable()
        {
            EventManager.OnAccuracyChanged.AddListener(OnAccuracyReached);
            prevAccuracy = 1f;
        }

        private void OnDisable()
        {
            EventManager.OnAccuracyChanged.RemoveListener(OnAccuracyReached);
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