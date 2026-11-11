using UnityEngine;

public class JouerSon : MonoBehaviour
{
    public AudioClip clip;

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void JouerParDessus()
    {
        if (source != null && clip != null)
        {
            source.PlayOneShot(clip);
        }
    }
}