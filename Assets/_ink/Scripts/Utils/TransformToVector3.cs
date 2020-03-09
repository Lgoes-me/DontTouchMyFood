using UnityEngine;
using ScriptableObjectArchitecture;

public class TransformToVector3 : MonoBehaviour
{
    public Vector3Variable position;

    void Update()
    {
        position.Value = transform.position;
    }
}
