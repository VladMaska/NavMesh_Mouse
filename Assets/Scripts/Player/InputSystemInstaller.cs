using Infrastructure_Beter.Services;
using UnityEngine;

namespace Player
{
    public class InputSystemInstaller : MonoBehaviour
    {
        [SerializeField] private Player _player;
        void Awake()
        {
            var inputComponent = ServiceAllocator.Container.Single<IInputSystem>();
            if (inputComponent.GetType() == typeof(NavInput))
            {
                this.gameObject.AddComponent<NavInput>()._playa = _player;
            }
            else if(inputComponent.GetType() == typeof(KeyboardInput))
            {
                //KeyboardInput finalInput = (KeyboardInput)inputComponent;
                this.gameObject.AddComponent<KeyboardInput>();
            }
        }
    
    }
}
