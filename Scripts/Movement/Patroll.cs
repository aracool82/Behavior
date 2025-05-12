using System.Collections.Generic;
using UnityEngine;

namespace _Project16_17.Scripts
{
    public class Patroll : IBehavior,IUpdateble
    {
        private List<Vector3> _points = new ();
        private Transform _source;
        private int _curentIndex;
        private bool _isUdateble;
        
        public Patroll(List<Vector3> points,Transform source)
        {
            _points = points;
            _source = source;
            _curentIndex = 0;
        }

        public Vector3 GetNextPoint()
        {
            Vector3 point = _points[_curentIndex];
            _curentIndex = (_curentIndex + 1) % _points.Count;
            return point;
        }

        public void DoAction()
        {
            
        }

        public void Update()
        {
            
        }
    }
}