using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip backgroundMusic; // Background music clip
    public AudioClip deathSound;      // Death sound clip

    private AudioSource audioSource;

    void Start()
    {
        // Dynamically create an AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        audioSource.loop = true;  // Enable looping
        audioSource.volume = 0.5f; // Set volume (0.0 - 1.0)
        audioSource.Play();       // Start playing background music
    }

    public void PlayDeathSound()
    {
        Debug.Log("deathsound is paying");
        // Stop current music
        audioSource.Stop();

        // Play the death sound
        audioSource.clip = deathSound;
        audioSource.loop = false;
        audioSource.volume = 0.25f;
        audioSource.Play();
    }
}
