using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Entity
{
    public class EntityManager : MonoBehaviour
    {
        private void Awake()
        {
            Init();
        }

        protected virtual void Init()
        {
            BoolVariable boolVar = (BoolVariable)ScriptableObject.CreateInstance("BoolVariable");

            GetComponent<ScriptableInputReceiver>().isBeingTouched = boolVar;
            GetComponent<EntityController>().touch = boolVar;

            GetComponent<EntityController>().Init();
        }
    }
}