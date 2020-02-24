using UnityEngine;

public class ComingState : EnemyState
{
    public Transform plateTransform;

    public override void OnStateUpdate()
    {
        destination = plateTransform.position;
    }

    public override void OnStateTouch(bool touch)
    {
        base.OnStateTouch(touch);

        enemy.SetState("Dragging");
    }

    public override void OnStateCollision(Collision2D collision)
    {
        base.OnStateCollision(collision);

        if (collision.transform.CompareTag("plate")) enemy.SetState("Waiting");
    }
}
