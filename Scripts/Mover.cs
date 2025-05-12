using UnityEngine;

namespace _Project16_17.Scripts
{
    public class Mover : IUpdateble
    {
        private Transform _source;
        private Transform _target;
        private float _speed;
        private float _minDistance;
        private bool _canMoveToTarget;
        

        public Mover(Transform source, float speed)
        {
            _source = source;
            _speed = speed;
            _canMoveToTarget = false;
            _target = null;
            _minDistance = 0.1f;
        }

        public void Move(Vector3 direction)
        {
            _source.Translate(direction * (_speed * Time.deltaTime), Space.World);
            _source.rotation = Quaternion.LookRotation(direction);
        }
        
        public void Update()
        {
            if(_canMoveToTarget == false)
                return;
            
            if (IsReachedTarget(_target) == false)
                Move(GetDirection(_target));
            else
                _canMoveToTarget = false;
        }

        public void MoveToTarget(Transform target)
        {
            _target = target;
            _canMoveToTarget = true; 
            Update();
        }

        private bool IsReachedTarget(Transform target)
            => (_source.position - target.position).magnitude <= _minDistance;

        private Vector3 GetDirection(Transform target)
            => (target.position - _source.position).normalized;
    }
}