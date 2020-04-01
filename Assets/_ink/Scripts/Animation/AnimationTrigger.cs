using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Animation
{
    public class AnimationTrigger : MonoBehaviour
    {
        public BoolVariable param;
        public string paramName;

        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if (param.Value)
            {
                _animator.SetTrigger(paramName);
                param.Value = false;
            }
        }
    }
}
