using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.DontTouchMyFood.System.Input;

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

            GetComponent<InputReceiver>().isBeingTouched = boolVar;
            GetComponent<EntityController>().touch = boolVar;

            GetComponent<EntityController>().Init();
        }
    }
}