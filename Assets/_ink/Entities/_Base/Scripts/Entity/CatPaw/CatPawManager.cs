using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class CatPawManager : EntityManager
    {
        public Vector3Variable platePosition;
        public EntityController entityController;

        protected override void Init()
        {
            base.Init();
        }

        private void OnEnable()
        {
            entityController.SetState(GetComponent<ComingState>());
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
