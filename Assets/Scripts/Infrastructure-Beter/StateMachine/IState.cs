namespace Infrastructure_Beter.StateMachine
{
    internal interface IState
    {
        void Enter();
        void Exit();
    }
}