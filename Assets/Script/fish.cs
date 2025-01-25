using UnityEngine;

public class Fish : MonoBehaviour
{
    public float speed = 2f;  // Speed of the fish movement
    public float leftBoundary = -10f;  // Leftmost position before switching direction
    public float rightBoundary = 10f;  // Rightmost position before switching direction

    private SpriteRenderer spriteRenderer;  // Reference to the SpriteRenderer component
    private bool movingRight = true;  // Determines the current movement direction

    void Start()
    {
        // Get the SpriteRenderer component attached to the fish
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Move the fish horizontally based on its direction
        float moveStep = speed * Time.deltaTime;
        if (movingRight)
        {
            transform.position += new Vector3(moveStep, 0, 0);

            // Check if the fish has reached the right boundary
            if (transform.position.x > rightBoundary)
            {
                movingRight = false;
                FlipSprite();
            }
        }
        else
        {
            transform.position -= new Vector3(moveStep, 0, 0);

            // Check if the fish has reached the left boundary
            if (transform.position.x < leftBoundary)
            {
                movingRight = true;
                FlipSprite();
            }
        }
    }

    // Flip the sprite's X scale to change direction
    private void FlipSprite()
    {
        spriteRenderer.flipX = !spriteRenderer.flipX;
    }
}