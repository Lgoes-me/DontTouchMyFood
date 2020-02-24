using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public InputReceiver touchInputReceiver;
    public MovementControl movement;

    public EnemyState state;

    private EnemyState[] _states;
    private Dictionary<string,EnemyState> _stateDict;


    private void Awake()
    {
        _states = GetComponents<EnemyState>();
        _stateDict = new Dictionary<string, EnemyState>();

        foreach(EnemyState state in _states)
        {
            state.enemy = this;
            _stateDict.Add(state.stateName, state);
        }

        state.OnStateEnter();
    }

    public void SetState(string stateName)
    {
        state.OnStateExit();
        this.state = _stateDict[stateName];
        state.OnStateEnter();
    }

    private void Update()
    {
        state.OnStateUpdate();
    }

    private void LateUpdate()
    {
        //state.OnStateTouch(touchInputReceiver.isTouched);

        if (state.destination != null)
        {
            movement.Move(state.destination, state.speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        state.OnStateCollision(collision);
    }
}
