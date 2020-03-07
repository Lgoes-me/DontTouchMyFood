using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

public class PawController : MonoBehaviour
{
    public BoolVariable touch;

    public PawState state;

    private PawState[] _states;

    private void Awake()
    {
        _states = GetComponents<PawState>();

        foreach(PawState pawState in _states)
        {
            pawState.Init(this);
        }

        state.OnStateEnter();
    }

    public void SetState(PawState newState)
    {
        state.OnStateExit();
        this.state = newState;
        state.OnStateEnter();
    }

    private void Update()
    {
        state.OnStateTouch(touch.Value);
        state.OnStateUpdate();
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        state.OnStateCollision(collision);
    }
}
