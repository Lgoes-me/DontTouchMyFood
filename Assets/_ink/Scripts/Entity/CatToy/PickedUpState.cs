using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.DontTouchMyFood.Entity;

public class PickedUpState : EntityState
{
    public Vector3Variable inputPosition;
    public float speed;
    private bool _touched;
    
    public override void OnStateInputReceived(bool touch)
    {
        base.OnStateInputReceived(touch);

        _touched = touch;
    }
    
    public override void OnStateUpdate()
    {
        if (_touched)
        {
            _rigidbody2D.position = Vector3.Lerp(transform.position, inputPosition.Value, speed);
        }
    }

    public override void OnStateCollision(Collision2D collision)
    {
        base.OnStateCollision(collision);

        if (collision.transform.CompareTag("paw"))
        {
            transform.parent = collision.transform;
            _controller.SetState(this.GetComponent<DeliveredState>());
        }
    }
}
