using UnityEngine;

public class PawState : MonoBehaviour
{
    protected PawController _controller;
    protected Rigidbody2D _rigidbody2D;

    public virtual void Init(PawController controller)
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _controller = controller;
    }

    public virtual void OnStateEnter()
    {

    }

    public virtual void OnStateTouch(bool touch)
    {

    }

    public virtual void OnStateUpdate()
    {

    }

    public virtual void OnStateCollision(Collision2D collision)
    {

    }

    public virtual void OnStateExit()
    {

    }
}
