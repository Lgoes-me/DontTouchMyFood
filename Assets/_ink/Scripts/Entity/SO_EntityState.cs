using UnityEngine;
using UnityEngine.Events;

namespace Ink.DontTouchMyFood.Entity
{
    [CreateAssetMenu(fileName = "new State", menuName = "state/SimpleState", order = 1)]
    public class SO_EntityState : ScriptableObject
    {
        public string stateName;
        public UnityAction stateEnter, StateExit, stateInput, stateCollision;
        protected EntityController _controller;

        public virtual void Init(EntityController controller)
        {
            _controller = controller;
        }

        public virtual void OnStateEnter()
        {
            stateEnter.Invoke();
        }

        public virtual void OnStateExit()
        {
            StateExit.Invoke();
        }

        public virtual void OnStateUpdate()
        {

        }

        public virtual void OnStateInputReceived(bool touch)
        {
            if (touch)
            {
                stateInput.Invoke();
            }
        }

        public virtual void OnStateCollision(Collision2D collision)
        {
            stateCollision.Invoke();
        }
    }
}