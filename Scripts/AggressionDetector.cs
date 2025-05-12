using UnityEngine;

namespace _Project16_17.Scripts
{
    public class AggressionDetector 
    {
        private Transform _target;
        private Transform _source;
        private float _aggressionDistance;

        public AggressionDetector(Transform target,Transform source, float aggressionDistance)
        {
            _target = target;
            _source = source;
            _aggressionDistance = aggressionDistance;
        }

        public bool IsDecected => GetDistance() <= _aggressionDistance;

        private float GetDistance()
            => (_target.position - _source.position).magnitude;
    }
}