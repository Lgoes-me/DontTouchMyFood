using UnityEngine;
using ScriptableObjectArchitecture;

public class ParallaxController : MonoBehaviour
{
    public QuaternionVariable gyroInput;
    public Vector3Variable acelerometerInput;

    private Gyroscope _gyroscope;
    
    void Start()
    {
        _gyroscope = Input.gyro;
        _gyroscope.enabled = true;
    }
    
    void Update()
    {
        gyroInput.Value = _gyroscope.attitude;
        acelerometerInput.Value = Input.acceleration;
    }
}
