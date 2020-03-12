using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class CatPawManager : EntityManager
    {
        public Vector3Variable platePosition;

        protected override void Init()
        {
            base.Init();

        }

        private void Update()
        {
            transform.up = platePosition.Value - transform.position;
        }
    }
}
