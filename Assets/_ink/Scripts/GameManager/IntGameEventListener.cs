using UnityEngine;
using UnityEngine.Events;
using ScriptableObjectArchitecture;

[ExecuteInEditMode]
public class IntGameEventListener : DebuggableGameEventListener, IGameEventListener<int>
{
    protected override ScriptableObject GameEvent { get { return _event; } }
    protected override UnityEventBase Response { get { return _response; } }

    [SerializeField]
    private IntGameEvent _previouslyRegisteredEvent = default(IntGameEvent);
    [SerializeField]
    private IntGameEvent _event = default(IntGameEvent);
    [SerializeField]
    private IntUnityEvent _response = default(IntUnityEvent);

    public void OnEventRaised(int arg)
    {
        RaiseResponse(arg);

        CreateDebugEntry(_response);

        AddStackTrace();
    }

    protected void RaiseResponse(int arg)
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
