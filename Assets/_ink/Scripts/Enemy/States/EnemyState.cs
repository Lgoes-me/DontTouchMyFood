using UnityEngine;

public class EnemyState : MonoBehaviour
{
    [HideInInspector]
    public Vector3 destination;

    [HideInInspector]
    public EnemyController enemy;
    
    public string stateName;

    public float speed;

    protected bool _isStateActive = false;

    public virtual void OnStateEnter()
    {
        _isStateActive = true;
    }

    public virtual void OnStateTouch(bool touch)
    {

    }

    public virtual void OnStateUpdate()
    {

    }

    public virtual void OnStateExit()
    {
        _isStateActive = false;
    }
}
