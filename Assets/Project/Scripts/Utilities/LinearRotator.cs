using UnityEngine;

namespace Project.Scripts.Utilities
{
    public class LinearRotator : MonoBehaviour
    {
        [SerializeField] private Vector3 eulerAngles;


        public void Update() => transform.rotation *= Quaternion.Euler(eulerAngles * Time.deltaTime);
    }
}