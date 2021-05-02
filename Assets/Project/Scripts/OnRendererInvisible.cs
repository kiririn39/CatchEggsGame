using UnityEngine;
using UnityEngine.Events;

namespace Project.Scripts
{
    [RequireComponent(typeof(Renderer))]
    public class OnRendererInvisible : MonoBehaviour
    {
        [SerializeField] private UnityEvent onBecameInvisibleEvents;
        
        
        private void OnBecameInvisible() => onBecameInvisibleEvents?.Invoke();
    }
}