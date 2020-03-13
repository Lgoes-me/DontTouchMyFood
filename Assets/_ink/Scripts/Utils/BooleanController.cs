using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Utils
{
    public class BooleanController : MonoBehaviour
    {
        public BoolVariable boolValue;

        public void SetBooleanValue(bool value)
        {
            boolValue.Value = value;
        }
    }
}
