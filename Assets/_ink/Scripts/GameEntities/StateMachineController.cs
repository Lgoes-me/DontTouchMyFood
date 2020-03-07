using UnityEngine;
using ScriptableObjectArchitecture;

public class StateMachineController: MonoBehaviour
{
    public BoolVariable touch;

    public BaseState state;
    private BaseState[] _states;

    public virtual void Init()
    {
        _states = GetComponents<BaseState>();

        foreach (BaseState _state in _states)
        {
            _state.Init(this);
        }

        state.OnStateEnter();
    }

    public virtual void SetState(BaseState newState)
    {
        state.OnStateExit();
        this.state = newState;
        state.OnStateEnter();
    }

    private void Update()
    {
        state.OnStateInputReceived(touch.Value);
        state.OnStateUpdate();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        state.OnStateCollision(collision);
    }
}
