using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemyState state;
    public MovementControl movement;

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

    private void Update()
    {
        state.OnStateUpdate();
        movement.Move(state.destination, state.speed);
    }

    public void SetState(string stateName)
    {
        state.OnStateExit();
        this.state = _stateDict[stateName];
        state.OnStateEnter();
    }
}
