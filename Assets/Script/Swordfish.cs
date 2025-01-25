using UnityEngine;

public class SwordfishLauncher : MonoBehaviour
{
    public Transform player;             // Reference to the player's transform
    public float launchSpeed = 10f;      // Speed of the swordfish when launched
    public LayerMask collisionLayer;     // Layer(s) for detecting collisions

    private Vector2 launchDirection;     // The direction the swordfish will move
    private bool hasStopped = false;     // Flag to check if movement should stop

    void Start()
    {
        // Calculate the launch direction toward the player
        launchDirection = (player.position - transform.position).normalized;

        // Rotate the swordfish to face the player
        float angle = Mathf.Atan2(launchDirection.y, launchDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Update()
    {
        if (!hasStopped)
        {
            // Move the swordfish in the launch direction
            transform.Translate(launchDirection * launchSpeed * Time.deltaTime, Space.World);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the swordfish hits an object on the specified collision layer
        if (((1 << collision.gameObject.layer) & collisionLayer) != 0)
        {
            // Stop movement upon collision
            hasStopped = true;

            // Optionally, you can add more behavior here (e.g., destroy the swordfish, play an animation)
            Debug.Log("Swordfish hit: " + collision.gameObject.name);
        }
    }
}
