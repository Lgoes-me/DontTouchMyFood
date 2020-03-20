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
            entityController.SetState(GetComponent<ComingState>());
            base.Init();
        }


        private void Update()
        {
            transform.up = platePosition.Value - transform.position;
        }
    }
}
