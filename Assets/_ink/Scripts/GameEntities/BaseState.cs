using UnityEngine;

public class BaseState: MonoBehaviour
{
    protected StateMachineController _controller;
    protected Rigidbody2D _rigidbody2D;

    public virtual void Init(StateMachineController controller)
    {
        _controller = controller;
        _rigidbody2D = GetComponent<Rigidbody2D>();
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

    public virtual void OnStateInputReceived(bool input)
    {

    }

    public virtual void OnStateCollision(Collision2D collision)
    {

    }
}
