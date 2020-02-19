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
        enemy.SetState("Dragging");
    }
}
