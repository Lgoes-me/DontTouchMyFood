using Ink.DontTouchMyFood.Animation;
using ScriptableObjectArchitecture;
using UnityEngine;

namespace Ink.DontTouchMyFood.Entity
{
    public class FoodPlateManager : EntityManager
    {
        protected override void Init()
        {
            base.Init();
            BoolVariable boolVar = GetComponent<EntityController>().touch;
            GetComponent<AnimationBool>().param = boolVar;
        }
    }
}
