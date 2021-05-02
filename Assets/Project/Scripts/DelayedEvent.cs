using UnityEngine;
using UnityEngine.Events;

namespace Project.Scripts
{
    public class DelayedEvent : MonoBehaviour
    {
        [Range(0.0f, 100.0f)]
        [SerializeField] private float delaySeconds;

        [SerializeField] private UnityEvent onTimeoutEvents;

        private float _timeLeft;

        private void Start() => _timeLeft = delaySeconds;

        private void Update()
        {
            _timeLeft -= Time.deltaTime;

            if (_timeLeft <= 0)
            {
                onTimeoutEvents?.Invoke();
                enabled = false;
            }
        }

        public void Restart()
        {
            _timeLeft = delaySeconds;
            enabled = true;
        }
    }
}