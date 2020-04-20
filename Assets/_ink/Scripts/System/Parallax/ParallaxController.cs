using UnityEngine;
using ScriptableObjectArchitecture;

public class ParallaxController : MonoBehaviour
{
    public QuaternionVariable gyroInput;
    public Vector3Variable acelerometerInput;

    private Gyroscope _gyroscope;
    private Vector3 _initialOrientation;
    
    void Start()
    {
        _gyroscope = Input.gyro;
        _gyroscope.enabled = true;
        _initialOrientation = Input.acceleration;

    }
    
    void Update()
    {
        gyroInput.Value = _gyroscope.attitude;
        acelerometerInput.Value = Input.acceleration - _initialOrientation;
    }
}
