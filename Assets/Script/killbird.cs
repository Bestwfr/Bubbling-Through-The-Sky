using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public string targetTag = "Fish"; // ชื่อ Tag ของวัตถุที่ต้องการลบ

    // ถ้าใช้ Collider แบบไม่ใช่ Trigger
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            Destroy(collision.gameObject); // ลบวัตถุที่ชน
        }
    }

    // ถ้าใช้ Collider แบบ Trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            Destroy(other.gameObject); // ลบวัตถุที่ชน
        }
    }
}
