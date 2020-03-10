using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.DontTouchMyFood.Entity;

public class SittingState : EntityState
{
    public override void OnStateInputReceived(bool input)
    {
        base.OnStateInputReceived(input);

        if (input)
        {
            _controller.SetState(this.GetComponent<PickedUpState>());
        }
    }
}
