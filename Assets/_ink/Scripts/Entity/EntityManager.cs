using UnityEngine;
using ScriptableObjectArchitecture;
using Ink.DontTouchMyFood.System.Touch;

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

            GetComponent<TouchReceiver>().isBeingTouched = boolVar;
            GetComponent<EntityController>().touch = boolVar;

            GetComponent<EntityController>().Init();
        }
    }
}