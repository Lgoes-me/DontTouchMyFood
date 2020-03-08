using UnityEngine;

namespace Ink.DontTouchMyFood.Entity
{
    public abstract class EntityState : MonoBehaviour
    {
        protected EntityController _controller;
        protected Rigidbody2D _rigidbody2D;

        public virtual void Init(EntityController controller)
        {
            _controller = controller;
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        public virtual void OnStateEnter()
        {

        }

        public virtual void OnStateExit()
        {

        }

        public virtual void OnStateUpdate()
        {

        }

        public virtual void OnStateInputReceived(bool input)
        {

        }

        public virtual void OnStateCollision(Collision2D collision)
        {

        }
    }
}
