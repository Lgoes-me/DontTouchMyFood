﻿using System.Collections;
using UnityEngine;
using ScriptableObjectArchitecture;

public class LeavingState : PawState
{
    public Vector3Variable platePosition;
    public float speed;
    public float waitTime;

    public override void OnStateEnter()
    {
        base.OnStateEnter();
        StartCoroutine(RemoveFromGame());
    }

    public override void OnStateUpdate()
    {
        _rigidbody2D.velocity = speed * (transform.position - platePosition.Value).normalized;
    }

    private IEnumerator RemoveFromGame()
    {
        yield return new WaitForSeconds(waitTime);

        Destroy(this.gameObject);
    }
}
