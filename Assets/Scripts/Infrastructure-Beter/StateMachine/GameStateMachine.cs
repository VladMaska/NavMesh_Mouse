using System;
using System.Collections.Generic;
using Infrastructure_Beter.Services;

namespace Infrastructure_Beter.StateMachine
{
    internal class GameStateMachine
    {
        public bool CameraFlag;
        private readonly Dictionary<Type, IState> _states;
        private IState _currentState;
        public GameStateMachine(ServiceAllocator services, Configs.Configs configs = null)
        {
            _states = new Dictionary<Type, IState>
            {
                [typeof(BootstrapState)] = new BootstrapState(this, services, configs),
                [typeof(LoadDataState)] = new LoadDataState(this, CameraFlag),
                [typeof(GameLoopState)] = new GameLoopState(this)
            };
        }
    
        public void Enter<TState>() where TState : class, IState
        {
            IState myState = ChangeState<TState>();
            myState.Enter();
        }

    
        private IState ChangeState<TState>() where TState : class, IState
        {
            _currentState?.Exit();
            TState myState = GetState<TState>();
            _currentState = myState;
            return myState;
        }

        private TState GetState<TState>() where TState : class, IState
        {
            return _states[typeof(TState)] as TState;
        }
    }
}