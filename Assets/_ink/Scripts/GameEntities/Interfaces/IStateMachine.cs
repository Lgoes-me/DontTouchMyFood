public interface IStateMachine<T>
    where T : IState
{
    void Init();

    void SetState(T newState);
}
