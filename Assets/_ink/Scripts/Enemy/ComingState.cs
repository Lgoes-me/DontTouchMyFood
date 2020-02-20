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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.name);
        if(collision.transform.CompareTag("plate")) enemy.SetState("Waiting");
    }
}
