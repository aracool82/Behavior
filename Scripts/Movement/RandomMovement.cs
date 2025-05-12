using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Project16_17.Scripts
{
    public class RandomMovement : IBehavior, IUpdateble
    {
        private List<Vector3> _directions = new() { Vector3.forward, Vector3.back, Vector3.right, Vector3.left };
        private Transform _source;
        private Mover _mover;
        private Vector3 _curentDirection;
        
        private float _changeDirectionTime;
        private float _timer;
        
        private bool _canMove;

        public RandomMovement(Transform source,float speed)
        {
            _mover = new Mover(source,speed);
            _source = source;
            _changeDirectionTime = 1f;
            _timer = 0f;
            _curentDirection = _directions[0];
            _canMove = false;
        }

        public Vector3 GetNextPoint()
            => _directions[Random.Range(0, _directions.Count)];

        public void DoAction()
           => _canMove = true;

        public void Update()
        {
            if(_canMove == false)
                return;
            
            _timer += Time.deltaTime;

            if (_timer >= _changeDirectionTime)
            {
                _timer = 0;
                _curentDirection = _directions[Random.Range(0, _directions.Count)];
            }
            
            _mover.Move(_curentDirection);
        }
    }
}