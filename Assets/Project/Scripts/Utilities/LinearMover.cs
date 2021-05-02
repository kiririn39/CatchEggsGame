using UnityEngine;

namespace Project.Scripts.Utilities
{
    public class LinearMover : MonoBehaviour
    {
        [SerializeField] private Vector3 direction;

        
        public void Update() => transform.position += direction * Time.deltaTime;
    }
}