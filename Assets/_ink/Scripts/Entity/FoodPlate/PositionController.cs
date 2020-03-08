using UnityEngine;
using ScriptableObjectArchitecture;

public class PositionController : MonoBehaviour
{
    public Vector3Variable position;

    void Update()
    {
        position.Value = transform.position;
    }
}
