using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Utils
{
    public class FloatToTextConversor : MonoBehaviour
    {
        public FloatVariable floatValue;
        public StringVariable stringValue;

        public string formatting;

        private void FixedUpdate()
        {
            stringValue.Value = floatValue.Value.ToString(formatting);
        }
    }
}
