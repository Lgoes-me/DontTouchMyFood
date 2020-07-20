using UnityEngine;
using ScriptableObjectArchitecture;

public class PlayParticleAtPosition : MonoBehaviour
{
    public Vector3Variable position;
    public ParticleSystem particleSystem;

    public void Play()
    {
        particleSystem.transform.position = new Vector3(position.Value.x, position.Value.y, transform.position.z);
        particleSystem.Play();
    }
}
