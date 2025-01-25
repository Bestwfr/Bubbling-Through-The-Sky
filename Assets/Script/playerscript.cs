using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class playerscript : MonoBehaviour
{
    public static bool ready = false;   // Indicates if the player is ready
    public static float dead = 0;      // Tracks "death" condition (e.g., health or timer)

    public GameObject deathCanvas;  // Reference to the DeathScreen script
    private BackgroundMusic backgroundMusic;

      private void Start() {
        deathCanvas.SetActive(false);
    }

    private void Update()
    {
        // Check if player is "dead" and the conditions are met
        if (ready && dead >= 8)
        {
           FindAnyObjectByType<BackgroundMusic>().PlayDeathSound();
            
            // Trigger the death screen
            TriggerDeathScreen();

            // Reset dead and load the death scene
            dead = 0;

            // Optional: Add a delay before loading the scene
            StartCoroutine(LoadSceneWithDelay());
        }
    }

    private void TriggerDeathScreen()
    {
        deathCanvas.SetActive(true);
    }

    private IEnumerator LoadSceneWithDelay()
    {
        // Optional: Wait for 2 seconds to let the death screen animation play
        yield return new WaitForSeconds(2f);

        // Load scene "1"
        SceneManager.LoadScene("1");
    }
}


