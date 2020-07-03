using UnityEngine;
using System.Collections;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class EatingState : EntityState
    {
        public FloatVariable gameScore;
        public FloatVariable currentScore, goalScore;
        public int variation;
        public BoolGameEvent gameEndEvent;
        public BoolVariable _canEat;

        private WaitForSeconds _timerWaiter = new WaitForSeconds(0.1F);

        public override void OnStateInputReceived(bool touch)
        {
            base.OnStateInputReceived(touch);

            if (_canEat.Value && touch && currentScore.Value <= goalScore.Value)
            {
                currentScore.Value += variation * Time.deltaTime;
                gameScore.Value += variation * Time.deltaTime /10;
            }
            if (_canEat.Value && currentScore.Value > goalScore.Value)
            {
                _canEat.Value = false;
                gameEndEvent.Raise(true);
            }
        }
    }
}