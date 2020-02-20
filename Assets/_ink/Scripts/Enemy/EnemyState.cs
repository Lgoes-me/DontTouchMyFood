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

    public virtual void OnStateUpdate()
    {

    }

    public virtual void OnStateExit()
    {

    }
}
