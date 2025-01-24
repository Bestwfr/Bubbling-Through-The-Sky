using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of left-right movement
    public float maxSpeed = 5f; // Optional: Limit the maximum speed
    private bool isGravityInverted = false;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FlipGravity();
        }
    }
    void FlipGravity()
    {
        // กลับด้านค่า Gravity Scale
        isGravityInverted = !isGravityInverted;
        rb.gravityScale = isGravityInverted ? -Mathf.Abs(rb.gravityScale) : Mathf.Abs(rb.gravityScale);

        //// หมุนวัตถุ (Optional: ทำให้ตัวละครกลับด้าน)
        //Vector3 scale = transform.localScale;
        //scale.y *= -1;
        //transform.localScale = scale;
    }
}
