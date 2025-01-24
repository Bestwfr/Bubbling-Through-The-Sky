using UnityEngine;

public class PlayerAirBoost : MonoBehaviour
{
    public float boostForce = 10f; // แรงดันของ Air Force
    private Rigidbody2D rb; // ใช้ Rigidbody2D สำหรับเกม 2D
    private Vector3 mouseWorldPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // ดึง Component Rigidbody2D จาก Player
    }

    void Update()
    {
        // หาตำแหน่งของเมาส์ในโลก 2D
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0; // ตั้งค่า z เป็น 0 เนื่องจากเป็นเกม 2D

        if (Input.GetMouseButtonDown(0)) // เมื่อคลิกซ้าย
        {
            BoostTowardsMouse();
        }
    }

    void BoostTowardsMouse()
    {
        // คำนวณทิศทางจากตำแหน่งของ Player ไปยังเมาส์
        Vector2 direction = ((Vector2)mouseWorldPosition - rb.position).normalized;

        // รีเซ็ตความเร็วเพื่อหลีกเลี่ยงการสะสมของแรงและลดการสั่น
        rb.linearVelocity = Vector2.zero;

        // เพิ่มแรงดีดตัวใน 2D
        rb.AddForce(direction * boostForce, ForceMode2D.Impulse);
    }
}
