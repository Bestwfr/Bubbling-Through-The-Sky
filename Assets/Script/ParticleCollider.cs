using UnityEngine;

public class ParticleCollider : MonoBehaviour
{
    private ParticleSystem particleSystem;

    void Start()
    {
        // Get the ParticleSystem component attached to the object
        particleSystem = GetComponent<ParticleSystem>();
    }

    void OnParticleCollision(GameObject other)
    {
        // Check if the particle hit the ground (ensure the ground object has a tag or layer)
        if (other.CompareTag("Ground"))
        {
            Debug.Log("A particle hit the ground!");
        }
    }
}