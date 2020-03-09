using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Utils
{
    public class IntToTextConversor : MonoBehaviour
    {
        public IntVariable intValue;
        public StringVariable stringValue;

        public string formatting;

        private void FixedUpdate()
        {
            stringValue.Value = intValue.Value.ToString(formatting);
        }
    }
}
