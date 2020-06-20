using UnityEngine;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Animation
{
    public class AnimationBool : MonoBehaviour
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
            _animator.SetBool(paramName, param.Value);
        }
    }
}