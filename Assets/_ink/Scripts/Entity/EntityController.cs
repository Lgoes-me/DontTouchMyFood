using UnityEngine;
using ScriptableObjectArchitecture;
using System.Collections.Generic;

namespace Ink.DontTouchMyFood.Entity
{
    public class EntityController : MonoBehaviour
    {
        public BoolVariable touch;
        public EntityState state;

        private Dictionary<string, EntityState> _states;

        public void Init()
        {
            EntityState[] states = GetComponents<EntityState>();
            _states = new Dictionary<string, EntityState>();

            foreach (EntityState state in states)
            {
                _states.Add(state.stateName, state);
                state.Init(this);
            }

            state.OnStateEnter();
        }

        public void SetState(string stateName)
        {
            state.OnStateExit();
            this.state = _states[stateName];
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