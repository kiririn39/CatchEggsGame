using UnityEngine;
using UnityEngine.Events;

namespace Project.Scripts
{
    public class ObjectCatcherData : MonoBehaviour
    {
        public enum Side
        {
            Left,
            Right
        }

        public Side incomingSide;
        public UnityEvent onCatchedEvents;
    }
}