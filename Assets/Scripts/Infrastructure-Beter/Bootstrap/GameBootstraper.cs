using Infrastructure_Beter.StateMachine;
using UnityEngine;


namespace Infrastructure_Beter.Bootstrap
{
    [DefaultExecutionOrder(-1000)]
    public class GameBootstraper : MonoBehaviour
    {
        public Configs.Configs Configs;
        private Game _game;

        private void Awake()
        {
            _game = new Game(Configs);
            _game.StateMachine.Enter<BootstrapState>();
        }
    }
}