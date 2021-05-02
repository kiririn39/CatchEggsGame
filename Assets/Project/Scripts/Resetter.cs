using UnityEngine;
using UnityEngine.Events;

namespace Project.Scripts
{
    public class Resetter : MonoBehaviour
    {
        [SerializeField] private UnityEvent onResetEvents;

        
        public void Reset() => onResetEvents?.Invoke();
    }
}