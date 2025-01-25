using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target;  // The object the camera will follow
    public float smoothSpeed = 0.125f;  // Adjust for smoothness
    public Vector3 offset;  // Offset relative to the target

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate desired position while ignoring the z-axis
            Vector3 desiredPosition = new Vector3(transform.position.x, target.position.y + offset.y, transform.position.z);
            
            // Smoothly interpolate to the desired position
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            
            // Update the camera's position
            transform.position = smoothedPosition;
        }
    }
}