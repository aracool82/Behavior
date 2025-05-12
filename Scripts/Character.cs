using UnityEngine;

namespace _Project16_17.Scripts
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Transform _target;

        private Mover _mover;
        
        private void Awake()
        {
            _mover = new Mover(transform,_speed);
            Debug.Log($"Таргет Старт  {_target}");
        }

        private void Update()
        {
            Debug.Log($"Таргет Апдате  " + _target);
            
            if(Input.GetKeyDown(KeyCode.Space))
                _mover.MoveToTarget(_target);

            _mover.Update();
        }

        public void Move(Vector3 direction)
            => _mover.Move(direction);
    }
}