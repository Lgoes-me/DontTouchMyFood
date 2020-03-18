using UnityEngine;
using UnityEngine.Events;
using ScriptableObjectArchitecture;

namespace Ink.DontTouchMyFood.Utils
{
    public class FloatGameEventListener : DebuggableGameEventListener, IGameEventListener<float>
    {
        protected override ScriptableObject GameEvent { get { return _event; } }
        protected override UnityEventBase Response { get { return _response; } }

        [SerializeField]
        private FloatGameEvent _previouslyRegisteredEvent = default(FloatGameEvent);
        [SerializeField]
        private FloatGameEvent _event = default(FloatGameEvent);
        [SerializeField]
        private FloatUnityEvent _response = default(FloatUnityEvent);

        public void OnEventRaised(float arg)
        {
            RaiseResponse(arg);

            CreateDebugEntry(_response);

            AddStackTrace();
        }

        protected void RaiseResponse(float arg)
        {
            _response.Invoke(arg);
        }
        private void OnEnable()
        {
            if (_event != null)
                Register();
        }
        private void OnDisable()
        {
            if (_event != null)
                _event.RemoveListener(this);
        }
        private void Register()
        {
            if (_previouslyRegisteredEvent != null)
            {
                _previouslyRegisteredEvent.RemoveListener(this);
            }

            _event.AddListener(this);
            _previouslyRegisteredEvent = _event;
        }
    }
}