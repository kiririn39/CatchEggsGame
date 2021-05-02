using UnityEngine;
using UnityEngine.Events;
using Side = Project.Scripts.ObjectCatcherData.Side;

namespace Project.Scripts
{
    public class ObjectsCatcher : MonoBehaviour
    {
        [SerializeField] private Side startingSide;

        [SerializeField] private UnityEvent onCatchedEvents;

        [SerializeField] private UnityEvent onTurnLeftEvents;
        [SerializeField] private UnityEvent onTurnRightEvents;

        private Side _currentSide;


        private void Start()
        {
            if (startingSide == Side.Left)
                TurnLeft();
            else
                TurnRight();
        }

        public void TryCatch(ObjectCatcherData data)
        {
            if (_currentSide != data.incomingSide) return;
            
            data.onCatchedEvents?.Invoke();
            onCatchedEvents?.Invoke();
        }

        public void TurnLeft()
        {
            _currentSide = Side.Left;
            onTurnLeftEvents?.Invoke();
        }

        public void TurnRight()
        {
            _currentSide = Side.Right;
            onTurnRightEvents?.Invoke();
        }
    }
}