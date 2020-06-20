using UnityEngine;
using TMPro;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.System.UI
{
    public class TextController : MonoBehaviour
    {
        public StringVariable text;
        private TextMeshProUGUI _textMesh;

        private void Start()
        {
            _textMesh = GetComponent<TextMeshProUGUI>();
        }

        void FixedUpdate()
        {
            string value = text.Value;

            if (_textMesh.text != value) _textMesh.text = value;
        }
    }
}
