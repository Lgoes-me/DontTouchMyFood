using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.DontTouchMyFood.Entity;

public class IdleState : EntityState
{
    public override void OnStateInputReceived(bool input)
    {
        base.OnStateInputReceived(input);

        if (input)
        {
            _rigidbody2D.velocity = Vector2.zero;
            _controller.SetState(this.GetComponent<DraggingButtonState>().stateName);
        }
    }
}
