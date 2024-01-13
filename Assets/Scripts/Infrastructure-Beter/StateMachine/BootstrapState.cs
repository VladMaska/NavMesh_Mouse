
using Configs;
using Infrastructure_Beter.Services;
using Player;
using UnityEngine;

namespace Infrastructure_Beter.StateMachine
{
    internal class BootstrapState : IState
    {
        private readonly ServiceAllocator _serviceAllocator;
        private readonly GameStateMachine _stateMachine;
        private readonly Configs.Configs _configs;
        private IInputSystem _inputSystem;

        public BootstrapState(GameStateMachine gameStateMachine, ServiceAllocator serviceAllocator, Configs.Configs configs = null)
        {
            _stateMachine = gameStateMachine;
            _serviceAllocator = serviceAllocator;
            _configs = configs;
            Debug.Log("Получена конфигурация: Управление - " + configs.myController);
            Debug.Log("Получена конфигурация для камеры: "+configs.camera);
            LoadStaticData();
            LoadVladMaska();
        }

        private void LoadVladMaska()
        {
            Debug.Log("VladMaska Hello!");
        }

        private void LoadStaticData()
        {
            //Загрузка
            if (_configs.myController == Controller.KeyController)
            {
                _serviceAllocator.RegisterSingle<IInputSystem>(new KeyboardInput());
            }
            else if(_configs.myController == Controller.MouseController)
            {
                _serviceAllocator.RegisterSingle<IInputSystem>(new NavInput());
            }
            _stateMachine.CameraFlag = _configs.camera;


        }

        public void Enter()
        {
            Debug.Log("Состояние Bootstrap ");
            _stateMachine.Enter<LoadDataState>();
        }

        public void Exit()
        {
            Debug.Log("Выход из состояния Bootstrap");
        }
    }

    
}