using UnityEngine;
using ScriptableObjectArchitecture;
using System.Collections.Generic;

namespace Ink.DontTouchMyFood.Entity
{
    public class EntityController : MonoBehaviour
    {
        public BoolVariable touch;
        public EntityState state;
        
        public void Init()
        {
            EntityState[] states = GetComponents<EntityState>();

            foreach (EntityState state in states)
            {
                state.Init(this);
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

        private void OnTriggerEnter2D(Collider2D collision)
        {
            state.OnStateTrigger(collision);
        }
    }
}