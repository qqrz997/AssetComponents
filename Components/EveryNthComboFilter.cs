using UnityEngine;
using UnityEngine.Events;

namespace SaberComponents.Components
{
    [AddComponentMenu("Beat Saber/SaberComponents/EveryNthComboFilter")]
    [RequireComponent(typeof(EventManager))]
    public class EveryNthComboFilter : MonoBehaviour
    {
        public int comboStep = 50;
        public UnityEvent nthComboReached;

        private EventManager eventManager;
        
        private void OnEnable()
        {
            if (eventManager == null) eventManager = GetComponent<EventManager>();
            eventManager.OnComboChanged.AddListener(OnComboStep);
        }

        private void OnDisable()
        {
            eventManager.OnComboChanged.RemoveListener(OnComboStep);
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