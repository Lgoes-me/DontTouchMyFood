using UnityEngine;

public class EnemyState : MonoBehaviour
{
    [HideInInspector]
    public Vector3 destination;

    [HideInInspector]
    public EnemyController enemy;
    
    public string stateName;
    public float speed;

    public virtual void OnStateEnter()
    {

    }

    public virtual void OnStateTouch()
    {

    }

    public virtual void OnStateUpdate()
    {

    }

    public virtual void OnStateCollision(Collision2D collision)
    {

    }

    public virtual void OnStateExit()
    {

    }
}
