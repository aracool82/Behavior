using UnityEngine;

namespace _Project16_17.Scripts
{
    public class AggressionDetector 
    {
        private Transform _targetPosition;
        private Transform _currentPosition;
        private float _aggressionDistance;

        public AggressionDetector(Transform targetPosition,Transform currentPosition, float aggressionDistance)
        {
            _targetPosition = targetPosition;
            _currentPosition = currentPosition;
            _aggressionDistance = aggressionDistance;
        }

        public bool IsDecected => GetDistance() <= _aggressionDistance;

        public float GetDistance()
            => (_targetPosition.position - _currentPosition.position).magnitude;
    }
}