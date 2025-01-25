using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class NPCFollowPlayer : MonoBehaviour
{
    public Transform player; // ลาก Transform ของ Player เข้ามาที่นี่
    public float followSpeed = 2f; // ความเร็วในการเดินตาม
    public float followDistance = 1.5f; // ระยะห่างจาก Player ที่ NPC จะหยุด

    private Rigidbody2D rb; // ตัวแปรสำหรับ Rigidbody2D
    private Vector2 movement; // ตัวแปรสำหรับเก็บทิศทางการเคลื่อนที่

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // ดึงข้อมูล Rigidbody2D
        rb.gravityScale = 0; // ปิดแรงโน้มถ่วงหากไม่ได้ใช้
    }

    void Update()
    {
        if (player != null)
        {
            // คำนวณระยะห่างระหว่าง NPC และ Player
            float distance = Vector2.Distance(transform.position, player.position);

            // ถ้าระยะห่างมากกว่าที่กำหนด ให้เดินเข้าไปหา Player
            if (distance > followDistance)
            {
                Vector2 direction = (player.position - transform.position).normalized; // คำนวณทิศทาง
                movement = direction;
            }
            else
            {
                movement = Vector2.zero; // หยุดเคลื่อนที่เมื่อใกล้พอ
            }
        }
    }

    void FixedUpdate()
    {
        // เคลื่อนที่ด้วย Rigidbody2D เพื่อให้ชนวัตถุได้
        rb.linearVelocity = movement * followSpeed;
    }
}
