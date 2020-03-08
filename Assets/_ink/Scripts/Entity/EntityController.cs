using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class EntityController : MonoBehaviour
    {
        public BoolVariable touch;

        public EntityState state;
        private EntityState[] _states;

        public virtual void Init()
        {
            _states = GetComponents<EntityState>();

            foreach (EntityState _state in _states)
            {
                _state.Init(this);
            }

            state.OnStateEnter();
        }

        public virtual void SetState(EntityState newState)
        {
            state.OnStateExit();
            this.state = newState;
            state.OnStateEnter();
        }

        private void Update()
        {
            state.OnStateInputReceived(touch.Value);
            state.OnStateUpdate();
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            state.OnStateCollision(collision);
        }
    }

}