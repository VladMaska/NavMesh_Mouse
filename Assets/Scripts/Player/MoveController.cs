using System;
using Infrastructure_Beter.Services;
using UnityEngine;

namespace Player
{
    public sealed class MoveController : MonoBehaviour
    {
        [SerializeField]
        private Player player;

        //[SerializeField]
        private IInputSystem _input;

        private void Awake()
        {
            _input = ServiceAllocator.Container.Single<IInputSystem>();
        }

        private void OnEnable()
        {
            this._input.OnMove += this.OnMove;
        }

        private void OnDisable()
        {
            this._input.OnMove -= this.OnMove;
        }

        private void OnMove(Vector2 direction)
        {
            var offset = new Vector3(direction.x, 0, direction.y) * Time.deltaTime * 10f;
            this.player.Move(offset);
        }
    }
}