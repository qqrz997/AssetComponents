using UnityEngine;
using UnityEngine.Events;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/Saber Components/ComboReachedEvent")]
    public class ComboReachedEvent : EventFilterBehaviour
    {
        public int comboTarget = 50;
        public UnityEvent nthComboReached;

        private void OnEnable()
        {
            EventManager.OnComboChanged.AddListener(OnComboReached);
        }

        private void OnDisable()
        {
            EventManager.OnComboChanged.RemoveListener(OnComboReached);
        }

        private void OnComboReached(int combo)
        {
            if (combo == comboTarget)
            {
                nthComboReached.Invoke();
            }
        }
    }
}