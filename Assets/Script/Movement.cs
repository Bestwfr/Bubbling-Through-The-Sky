using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of left-right movement
    public float maxSpeed = 5f; // Optional: Limit the maximum speed

    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Horizontal input for left-right movement
        float moveX = Input.GetAxis("Horizontal");

        // Apply force for horizontal movement
        rb.AddForce(new Vector2(moveX * moveSpeed, 0f), ForceMode2D.Force);

        // Optional: Limit the maximum velocity
        rb.velocity = new Vector2(
            Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed), 
            Mathf.Clamp(rb.velocity.y, -maxSpeed, maxSpeed)
        );
    }
}
