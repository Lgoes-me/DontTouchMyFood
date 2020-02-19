using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public EnemyState state;

    public EnemyState[] states;

    private void Awake()
    {
        
    }

    private void DoAction()
    {
        state.DoAction();
    }

    public void SetState(EnemyState state)
    {
        state.OnStateExit();
        this.state = state;
        state.OnStateEnter();
    }
}
