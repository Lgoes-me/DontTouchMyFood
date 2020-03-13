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
            _textMesh.text = text.Value;
        }
    }
}
