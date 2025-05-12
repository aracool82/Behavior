using UnityEngine;

namespace _Project16_17.Scripts
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private State _state;
        [SerializeField] private Rest _Rest;
        [SerializeField] private Reaction _reaction;

        private AggressionDetector _aggressionDetector;
        private IBehavior _behavior;
        private float _speed;

        public void Initialize(Transform targetTransform,Transform source )
        {
            float distance = 3;
            //_aggressionDetector = new AggressionDetector(targetTransform,source,distance);
            _state = State.AtRest;
            _behavior = new StandInPlace();
            // _behavior = new RandomMovement(transform, _speed);
        }

        private void Update()
        {
            // _state = _aggressionDetector.IsDecected ? State.Reaction : State.AtRest;
            //
            // if(_state == State.AtRest)
            //     _behavior.DoAction();
        }
    }
}