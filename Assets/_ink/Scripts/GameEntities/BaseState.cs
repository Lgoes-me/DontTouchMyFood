using UnityEngine;

public class BaseState <T> : MonoBehaviour, IState
    where T : StateMachineController
{
    protected T _controller;

    protected virtual void Init(T controller)
    {
        _controller = controller;
    }

    public virtual void OnStateEnter()
    {

    }

    public virtual void OnStateExit()
    {

    }

    public virtual void OnStateUpdate()
    {

    }
}
