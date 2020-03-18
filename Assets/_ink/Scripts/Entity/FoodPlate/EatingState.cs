using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.DontTouchMyFood.Entity;

public class EatingState : EntityState
{
    public IntVariable feedingScore;
    public int variation;

    public override void OnStateInputReceived(bool touch)
    {
        base.OnStateInputReceived(touch);
           
        if(touch)
        {
            feedingScore.Value += variation;
        }
    }
}
