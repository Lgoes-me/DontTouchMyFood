using UnityEngine;
using UnityEngine.UI;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.UI
{
    public class ProgressBarController : MonoBehaviour
    {
        public FloatVariable fillPercent;
        public bool invertido;
        private Image image;

        private void Start()
        {
            image = GetComponent<Image>();
        }

        private void FixedUpdate()
        {
            float value = fillPercent.Value;

            if (image.fillAmount != value) image.fillAmount = invertido ? 1 - value : value;
        }
    }
}