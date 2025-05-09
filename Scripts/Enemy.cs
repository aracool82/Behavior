using UnityEngine;

namespace _Project16_17.Scripts
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private State _state;
        [SerializeField] private Rest _Rest;
        [SerializeField] private Reaction _reaction;
        [SerializeField] private Mover _mover;

        private AggressionDetector _aggressionDetector;
        private IMoveble _moveble;

        public void Initialize(Transform targetTransform,Transform source ,float distance)
        {
            _aggressionDetector = new AggressionDetector(targetTransform,source,distance);
            _state = State.AtRest;
        }

        private void Update()
        {
            _state = _aggressionDetector.IsDecected ? State.Reaction : State.AtRest;

            
        }
    }
}