using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathScreen : MonoBehaviour
{
    public CanvasGroup deathScreenCanvas;  // Assign the Canvas Group for the death screen
    public float fadeDuration = 2f;       // Duration of the fade effect

    private bool isFading = false;

    public void TriggerDeathScreen()
    {
        if (!isFading)
        {
            StartCoroutine(FadeInDeathScreen());
        }
    }

    private IEnumerator FadeInDeathScreen()
    {
        isFading = true;
        float elapsed = 0f;

        // Gradually increase alpha
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            deathScreenCanvas.alpha = Mathf.Lerp(0f, 1f, elapsed / fadeDuration);
            yield return null;
        }

        deathScreenCanvas.alpha = 1f;
        isFading = false;
    }
}
