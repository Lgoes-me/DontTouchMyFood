/*using UnityEngine;

public class CardDrag : CardInput
{
    public Transform previousPosition;
    public float zDepth;

    private CardMovement movement;
    private Camera mainCamera;

    private Transform _actionZone;
    private Vector3 _mousePosition;
           
    protected override void Start()
    {
        base.Start();

        movement = GetComponent<CardMovement>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        _mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDepth);
        _mousePosition = mainCamera.ScreenToWorldPoint(_mousePosition);
    }

    private void OnMouseDrag()
    {
        movement.Move(_mousePosition, 0.6f);
    }

    private void OnMouseUp()
    {
        previousPosition = _actionZone;

        if (previousPosition.GetComponent<ActionZone>())
        {
            previousPosition.GetComponent<ActionZone>().DropCard(card);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        _actionZone = collision.transform;
    }

    private void OnTriggerStay(Collider collision)
    {
        _actionZone = collision.transform;
    }

    private void OnTriggerExit(Collider collision)
    {
        _actionZone = previousPosition;
    }
}
*/