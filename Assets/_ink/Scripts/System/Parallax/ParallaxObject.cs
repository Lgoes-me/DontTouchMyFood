using UnityEngine;
using ScriptableObjectArchitecture;

public class ParallaxObject : MonoBehaviour
{
    public QuaternionVariable gyroQuaternion;
    public Vector3Variable acelInput;
    public float objectIndex;
    private Vector3 _initialPosition;

    private void Start()
    {
        _initialPosition = transform.position;
    }

    void Update()
    {
        float xTranslation = -(gyroQuaternion.Value.eulerAngles.x  + acelInput.Value.x) * objectIndex;
        float yTranslation = -(gyroQuaternion.Value.eulerAngles.y + acelInput.Value.y) * objectIndex;

        Vector3 translation = new Vector3(xTranslation, yTranslation, 0);

        transform.position = _initialPosition + translation;
    }
}
