using UnityEngine;

public class ComingState : EnemyState
{
    public Transform plateTransform;

    public override void OnStateUpdate()
    {
        destination = plateTransform.position;
    }

    private void OnMouseEnter()
    {
        if (_isStateActive) enemy.SetState("Dragging");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(_isStateActive && collision.transform.CompareTag("plate") ) enemy.SetState("Waiting");
    }
}
