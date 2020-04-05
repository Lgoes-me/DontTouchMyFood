using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.DontTouchMyFood.Entity;
using ScriptableObjectArchitecture;

public class DraggingButtonState : EntityState
{
    public Vector3Variable inputPosition;
    public BoolGameEvent endScene;
    private Vector3 offset;

    public float waitTime;
    public float speed;

    private bool _touched;

    public override void OnStateInputReceived(bool touch)
    {
        base.OnStateInputReceived(touch);

        _touched = touch;
        offset = inputPosition.Value - transform.localPosition;
        StartCoroutine(EndScene());
    }


    public override void OnStateUpdate()
    {
        if (_touched)
        {
            _rigidbody2D.position = Vector3.Lerp(transform.position, new Vector3(inputPosition.Value.x - offset.x, inputPosition.Value.y - offset.y, inputPosition.Value.z), speed);
        }
    }

    private IEnumerator EndScene()
    {
        yield return new WaitForSeconds(waitTime);

        endScene.Raise(true);
    }
}
