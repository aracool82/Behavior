using UnityEngine;

namespace _Project16_17.Scripts
{
    public class NoMovement : MonoBehaviour, IMoveble
    {
        public void Move()
        {
            Debug.Log("noMovement");
        }
    }
}