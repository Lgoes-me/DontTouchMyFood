using UnityEngine;
using ScriptableObjectArchitecture;

public class ParallaxController : MonoBehaviour
{
    public QuaternionVariable gyroInput;
    public Vector3Variable acelerometerInput;

    private Gyroscope _gyroscope;

    private bool _useGyro = false;

    Matrix4x4 baseMatrix = Matrix4x4.identity;

    public void Calibrate()
    {
        Quaternion rotate = Quaternion.FromToRotation(new Vector3(0.0f, 0.0f, -1.0f), Input.acceleration);

        Matrix4x4 matrix = Matrix4x4.TRS(Vector3.zero, rotate, new Vector3(1.0f, 1.0f, 1.0f));

        this.baseMatrix = matrix.inverse;
    }

    void Start()
    {
        _useGyro = SystemInfo.supportsGyroscope;

        _gyroscope = Input.gyro;
        _gyroscope.enabled = true;

        Calibrate();

    }
    
    void Update()
    {
        if(_useGyro)
            gyroInput.Value = _gyroscope.attitude;
        else
            acelerometerInput.Value = Vector3.ClampMagnitude(acelerometerInput.Value + baseMatrix.MultiplyVector(Input.acceleration), 1f);
    }
}
