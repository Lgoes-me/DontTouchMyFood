using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Utils
{
    public class FloatPercentage : MonoBehaviour
    {
        public FloatVariable max, current;
        public FloatVariable percentage;

        private void FixedUpdate()
        {
            float value = current.Value / max.Value;

            if(percentage.Value != value) percentage.Value = value;
        }
    }
}
