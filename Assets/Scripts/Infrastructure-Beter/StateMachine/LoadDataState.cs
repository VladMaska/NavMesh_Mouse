using System;
using UnityEngine;

namespace Infrastructure_Beter.StateMachine
{
    internal class LoadDataState : IState
    {
        private readonly GameStateMachine _stateMachine;

        public LoadDataState(GameStateMachine gameStateMachine, bool cameraFlag)
        {
            _stateMachine = gameStateMachine;
        }

        public void Enter()
        {
            Debug.Log("Вход в состояние 2!");
            Debug.Log("Флаг камеры в загрузке данных: "+_stateMachine.CameraFlag);
            if (_stateMachine.CameraFlag == true)
            {
                GameObject system = GameObject.Find("[System]");
                Debug.Log("Найденный объект: " + system.name);
                for (int i = 0; i < system.transform.childCount; i++)
                {
                    if (system.transform.GetChild(i).gameObject.activeSelf == false)
                    {
                        system.transform.GetChild(i).gameObject.SetActive(true);
                    }
                }
            }
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}