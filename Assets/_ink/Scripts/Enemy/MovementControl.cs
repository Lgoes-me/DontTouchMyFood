using UnityEngine;

public class MovementControl : MonoBehaviour
{
    private float speed;
    private Vector3 destination;
    private bool shouldMove;

    private Rigidbody2D rb;
    private Vector3 _position;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (shouldMove) _position = Vector3.Lerp(transform.position, destination, speed);
    }

    private void FixedUpdate()
    {
        if (shouldMove) rb.position = _position;
    }

    public void Move(Vector3 destination, float speed)
    {
        this.destination = destination;
        this.speed = speed;
        this.shouldMove = true;
    }

    public void Stop()
    {
        this.shouldMove = false;
    }

    public void Resume()
    {
        this.shouldMove = true;
    }
}
