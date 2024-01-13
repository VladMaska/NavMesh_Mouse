using System;
using UnityEngine;
using UnityEngine.AI;

namespace Player
{
    public class NavInput : MonoBehaviour, IInputSystem
    {
        //public Action<Vector2> OnMove;

        public Vector3 point;
        public Player _playa;
        private NavMeshAgent _agent;

        public Action<Vector2> OnMove { get; set; }

        private void Start() =>_agent = _playa.gameObject.GetComponent<NavMeshAgent>();


        public void Update()
        {
            this.MousePosition();
        }

        private void MousePosition()
        {
            if ( !Input.GetMouseButtonDown( 0 ) ) return;
        
            // Create a ray from the camera through the mouse cursor position
            var ray = Camera.main.ScreenPointToRay( Input.mousePosition );

            // Perform the raycast
            if ( !Physics.Raycast( ray, out var hit ) ) return;
        
            point = hit.point;
            point.y = 0;
            // point.Normalize();
        
            _agent.SetDestination( point );
            this.Move(point);
        }

        public void Move(Vector2 direction)
        {
            this.OnMove?.Invoke(direction);
        }
        
        
    }

    
}