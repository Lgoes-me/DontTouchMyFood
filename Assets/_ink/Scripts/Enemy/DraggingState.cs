using UnityEngine;

public class DraggingState : EnemyState
{
    public float zDepth;
    public Camera mainCamera;
    
    public override void OnStateUpdate()
    {
        destination = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);
        destination = mainCamera.ScreenToWorldPoint(destination);
    }
}
