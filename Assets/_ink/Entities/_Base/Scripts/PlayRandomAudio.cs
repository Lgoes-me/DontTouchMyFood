using UnityEngine;

public class PlayRandomAudio : MonoBehaviour
{
    public AudioClip[] audios;
    public AudioSource audioSource;
    
    public void PlayAudio()
    {
        int value = Random.Range(0, audios.Length);
        audioSource.PlayOneShot(audios[value]);
    }
}
