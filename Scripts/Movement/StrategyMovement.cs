using System;
using UnityEngine;

namespace _Project16_17.Scripts
{
    public class StrategyMovement : MonoBehaviour
    {
        private IMoveble _moveble;

        public void Initialise(IMoveble moveble)
        {
            _moveble = moveble;
        }
    }
}