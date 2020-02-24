using UnityEngine;

public class MovementControl : MonoBehaviour
{
    private float _speed;
    private Vector3 _direction;

    private Rigidbody2D _rigidbody2D;
    private Vector3 _position;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _position = transform.position;
    }

    private void FixedUpdate()
    {
         _rigidbody2D.position = _position;
    }

    private void Update()
    {
        _position = Vector3.Lerp(transform.position, _direction, _speed);
    }

    public void Move(Vector3 direction, float speed)
    {
        Debug.Log(direction + "," + speed);
        _direction = direction;
        _speed = speed;
    }
}
