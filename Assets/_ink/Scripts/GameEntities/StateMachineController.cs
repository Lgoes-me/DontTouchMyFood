using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineController<T> : MonoBehaviour, IStateMachine<T>
    where T : BaseState<>
{
    public IState state;

    private IState[] _states;

    public virtual void Init()
    {
        _states = GetComponents<IState>();

        foreach (IState pawState in _states)
        {
            pawState.Init(this);
        }

        state.OnStateEnter();
    }

    public virtual void SetState(IState newState)
    {

    }
}
