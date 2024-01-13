using System;
using UnityEngine;

namespace Player
{
    public sealed class KeyboardInput : MonoBehaviour, IInputSystem
    {
        //public Action<Vector2> OnMove;

        public void Update()
        {
            this.HandleKeyboard();
        }

        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                this.Move(Vector2.up);
                Debug.Log("Только вперёд!");
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                this.Move(Vector2.down);
                Debug.Log("Назад!");
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                this.Move(Vector2.left);
                Debug.Log("Влево!");
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                this.Move(Vector2.right);
                Debug.Log("Вправо!");
            }
        }

        public Action<Vector2> OnMove { get; set; }

        public void Move(Vector2 direction)
        {
            this.OnMove?.Invoke(direction);
        }
        
    }
}