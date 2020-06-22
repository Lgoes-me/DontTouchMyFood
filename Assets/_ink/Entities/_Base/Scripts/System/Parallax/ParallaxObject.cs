using UnityEngine;
using ScriptableObjectArchitecture;

public class ParallaxObject : MonoBehaviour
{
    public QuaternionVariable gyroQuaternion;
    public Vector3Variable acelInput;
    public float objectIndex;

    private Vector3 _realPosition;
    private Vector3 _translation;

    private void Start()
    {
        _realPosition = transform.position;
        _translation = Vector3.zero;
    }

    private void Update()
    {
        _realPosition = transform.position - _translation;
    }

    private void LateUpdate()
    {
        float xTranslation = - (gyroQuaternion.Value.eulerAngles.x  + acelInput.Value.x) * objectIndex;
        float yTranslation = - (gyroQuaternion.Value.eulerAngles.y + acelInput.Value.y) * objectIndex;

        _translation = new Vector3(xTranslation, yTranslation, 0);

        transform.position = Vector3.Lerp(transform.position, _realPosition + _translation, 30 * Time.deltaTime);
    }
}
