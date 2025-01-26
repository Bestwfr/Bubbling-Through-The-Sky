using UnityEngine;

public class PlayerAirBoost : MonoBehaviour
{
    [SerializeField]
    private float boostForce = 20f; // Boost force
    public GameObject dustVFXPrefab; // Assign your particle system prefab here

    private Rigidbody2D rb; // Rigidbody2D for the player
    private Vector3 mouseWorldPosition;

    private float currentForce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get Rigidbody2D from the player
    }

    void Update()
    {
        // Get the mouse position in world space
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0; // Set z to 0 for 2D games

        currentForce = Mathf.Max(0, boostForce - playerscript.dead);
        if (Input.GetMouseButtonDown(0)) // On left mouse click
        {
            BoostTowardsMouse();
        }
    }




    void BoostTowardsMouse()
    {
        // Debug.Log(currentForce);
        // Calculate direction from player to the mouse position
        Vector2 direction = ((Vector2)mouseWorldPosition - rb.position).normalized;

        // Reset velocity to avoid buildup of forces
        rb.velocity = Vector2.zero;

        // Apply impulse force
        rb.AddForce(direction * currentForce, ForceMode2D.Impulse);

        // Instantiate dust effect and rotate it based on direction
        CreateDustEffect(direction);
    }

    void CreateDustEffect(Vector2 direction)
    {
        if (dustVFXPrefab != null)
        {
            // Calculate position for the dust effect
            Vector3 spawnPosition = rb.position - (Vector2)(direction * 0.4f); // Slight offset behind the player

            // Instantiate the dust particle effect
            GameObject dustEffect = Instantiate(dustVFXPrefab, spawnPosition, Quaternion.identity);

            // Rotate the dust effect to match the direction toward the mouse
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90; // +180 for the opposite direction
            dustEffect.transform.rotation = Quaternion.Euler(0, 0, angle);

            // Optionally destroy the particle system after it finishes playing
            Destroy(dustEffect, 2f); // Adjust time based on particle system duration
        }
    }
}
