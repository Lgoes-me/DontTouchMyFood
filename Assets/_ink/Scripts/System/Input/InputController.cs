using UnityEngine;
using ScriptableObjectArchitecture;

public class InputController : MonoBehaviour
{
    public Vector3Variable inputPosition;

    private float _zDepth = -10;
    private Camera _camera;
    private LayerMask _mask;

    private void Awake()
    {
        _camera = Camera.main;
        _mask = LayerMask.GetMask("Paw","Plate");
    }
    
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPosWorld = _camera.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
            touchPosWorld.z = _zDepth;
            inputPosition.Value = touchPosWorld;
            
            RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld, _camera.transform.forward, 12f, _mask);
           
        }
    }
}
