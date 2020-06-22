using UnityEngine.Events;

namespace Ink.DontTouchMyFood.Entity
{
    public class IdleState : EntityState
    {
        public UnityEvent inputEvent;

        public override void OnStateInputReceived(bool input)
        {
            base.OnStateInputReceived(input);
            if (input) inputEvent.Invoke();
        }
    }
}