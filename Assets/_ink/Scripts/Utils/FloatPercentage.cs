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
            percentage.Value = current.Value / max.Value;
        }
    }
}
