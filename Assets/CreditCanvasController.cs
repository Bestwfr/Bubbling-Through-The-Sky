using UnityEngine;

public class CreditCanvasController : MonoBehaviour
{
    // Reference to the credit canvas
    [SerializeField] private GameObject creditCanvas;

    void Start()
    {
        // Ensure the credit canvas is hidden at the start
        if (creditCanvas != null)
        {
            creditCanvas.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Credit canvas is not assigned in the inspector.");
        }
    }

    // Method to show the credit canvas
    public void ShowCreditCanvas()
    {
        if (creditCanvas != null)
        {
            creditCanvas.SetActive(true);
        }
    }

    // Method to hide the credit canvas
    public void HideCreditCanvas()
    {
        if (creditCanvas != null)
        {
            creditCanvas.SetActive(false);
        }
    }
}
