using UnityEngine;
using UnityEngine.Events;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/Saber Components/EveryNthComboFilter")]
    public class EveryNthComboFilter : EventFilterBehaviour
    {
        public int comboStep = 50;
        public UnityEvent nthComboReached;

        private void OnEnable()
        {
            EventManager.OnComboChanged.AddListener(OnComboStep);
        }

        private void OnDisable()
        {
            EventManager.OnComboChanged.RemoveListener(OnComboStep);
        }

        private void OnComboStep(int combo)
        {
            if (combo % comboStep == 0 && combo != 0)
            {
                nthComboReached.Invoke();
            }
        }
    }
}