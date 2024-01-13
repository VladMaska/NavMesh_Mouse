using UnityEngine;

namespace Player
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField]
        private float speed = 10.5f;
        
        public void Move(Vector3 offset)
        {
            this.transform.position += offset * this.speed;
        }

        public Vector3 GetPosition()
        {
            return this.transform.position;
        }
    }
}