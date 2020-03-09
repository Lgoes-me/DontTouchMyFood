using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class EntityController : MonoBehaviour
    {
        public BoolVariable touch;

        public EntityState state;
        private EntityState[] _states;

        public void Init()
        {
            _states = GetComponents<EntityState>();

            foreach (EntityState _state in _states)
            {
                _state.Init(this);
            }

            state.OnStateEnter();
        }

        public void SetState(EntityState newState)
        {
            state.OnStateExit();
            this.state = newState;
            state.OnStateEnter();
        }

        private void FixedUpdate()
        {
            state.OnStateInputReceived(touch.Value);
        }

        private void Update()
        {
            state.OnStateUpdate();
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            state.OnStateCollision(collision);
        }
    }

}