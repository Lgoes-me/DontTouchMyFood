using UnityEngine;
using System.Collections;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class EatingState : EntityState
    {
        public IntVariable feedingScore, goalScore;
        public int variation;
        public BoolGameEvent gameEndEvent;

        private WaitForSeconds _timerWaiter = new WaitForSeconds(0.1F);
    
        private bool _canEat = true;

        public override void OnStateInputReceived(bool touch)
        {
            base.OnStateInputReceived(touch);
            

        }

        private IEnumerator IncreaseScore()
        {
            while (_canEat && feedingScore.Value <= goalScore.Value)
            {
                feedingScore.Value += variation;
                yield return _timerWaiter;
            }

            if (feedingScore.Value > goalScore.Value)
            {
                _canEat = false;
                gameEndEvent.Raise(true);
            }
        }
    }
}