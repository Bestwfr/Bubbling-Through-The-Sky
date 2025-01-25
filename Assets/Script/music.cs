using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip backgroundMusic; // Background music clip
    public AudioClip deathSound;      // Death sound clip
    public float backgroundMusicVolume = 0.5f; // Volume for background music
    public float deathSoundVolume = 0.5f;      // Volume for death sound

    private AudioSource audioSource;

    void Start()
    {
        // Dynamically create an AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        audioSource.volume = backgroundMusicVolume;
        audioSource.loop = true;  // Enable looping
        audioSource.Play();       // Start playing background music
    }

    public void PlayDeathSound()
    {
        if (deathSound != null)
        {
            Debug.Log("PlayDeathSound() called");
            audioSource.Stop(); // Stop current music
            audioSource.clip = deathSound;
            audioSource.volume = deathSoundVolume; // Set death sound volume
            audioSource.loop = false; // No looping for death sound
            audioSource.Play(); // Play the death sound
        }
        else
        {
            Debug.LogError("Death sound clip is not assigned!");
        }
    }
}
