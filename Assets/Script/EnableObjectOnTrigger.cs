using UnityEngine;

public class EnableObjectOnceOnTrigger : MonoBehaviour
{
    public GameObject objectToEnable;  // The object to enable
    
    private void Start() {
        objectToEnable.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Check if the player enters the trigger
        {
            if (objectToEnable != null)
            {
                objectToEnable.SetActive(true);  // Enable the object
            }
        }
    }
}
