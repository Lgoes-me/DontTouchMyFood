using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class CatPawManager : EntityManager
    {
        public Vector3Variable platePosition;
        public EntityController entityController;
        public CapsuleCollider2D capsuleCollider;

        protected override void Init()
        {
            base.Init();
        }

        private void OnEnable()
        {
            entityController.SetState(GetComponent<ComingState>());
            capsuleCollider.isTrigger = false;
        }

        private void Update()
        {
            transform.up = platePosition.Value - transform.position;
        }

        private void OnDisable()
        {
            entityController.SetState(GetComponent<ComingState>());
        }
    }
}
