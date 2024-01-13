using Infrastructure_Beter.Services;
using Infrastructure_Beter.StateMachine;

namespace Infrastructure_Beter.Bootstrap
{
    internal class Game
    {
        public GameStateMachine StateMachine;

        public Game(Configs.Configs configs = null)
        {
            StateMachine = new GameStateMachine(ServiceAllocator.Container, configs);
        }
    }
}