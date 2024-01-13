using System;
using Infrastructure_Beter.Services;
using UnityEngine;

namespace Player
{
    public interface IInputSystem : IService
    {
        public Action<Vector2> OnMove { get; set; }

        public void Move(Vector2 pos);
    }
}