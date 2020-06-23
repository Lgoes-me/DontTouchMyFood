using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Animation
{
    public class AnimationFloat : MonoBehaviour
    {
        public FloatVariable param;
        public string paramName;

        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            _animator.SetFloat(paramName, 1 - param.Value);
        }
    }
}