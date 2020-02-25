using System.Collections;
using UnityEngine;

public class LeavingState : PawState
{
    public Transform plateTransform;
    public float speed;
    public float waitTime;

    public override void OnStateEnter()
    {
        base.OnStateEnter();
        StartCoroutine(RemoveFromGame());
    }

    public override void OnStateUpdate()
    {
        _rigidbody2D.velocity = speed * (transform.position - plateTransform.position).normalized;
    }

    private IEnumerator RemoveFromGame()
    {
        yield return new WaitForSeconds(waitTime);

        Destroy(this.gameObject);
    }
}
