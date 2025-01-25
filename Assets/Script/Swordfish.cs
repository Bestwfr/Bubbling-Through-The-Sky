using UnityEngine;

public class SwordfishLauncher : MonoBehaviour
{
    public Transform player;             // Reference to the player's transform
    public float launchSpeed = 10f;      // Speed of the swordfish when launched
    public LayerMask collisionLayer;     // Layer(s) for detecting collisions

    private Vector2 launchDirection;     // The direction the swordfish will move
    private Rigidbody2D rb;              // Reference to the Rigidbody2D component

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();

        // Calculate the launch direction toward the player
        launchDirection = (player.position - transform.position).normalized;

        // Rotate the swordfish to face the player
        float angle = Mathf.Atan2(launchDirection.y, launchDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        // Launch the swordfish
        rb.velocity = launchDirection * launchSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the swordfish hits an object on the specified collision layer
        if (((1 << collision.gameObject.layer) & collisionLayer) != 0)
        {
            // Stop movement upon collision
            rb.velocity = Vector2.zero;

            // Optionally, you can add more behavior here (e.g., destroy the swordfish, play an animation)
            Debug.Log("Swordfish hit: " + collision.gameObject.name);
        }
    }
}
