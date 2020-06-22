using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Utils
{
    public class IntPercentage : MonoBehaviour
    {
        public IntVariable max, current;
        public FloatVariable percentage;

        private void FixedUpdate()
        {
            percentage.Value = (float)current.Value / max.Value;
        }
    }
}
