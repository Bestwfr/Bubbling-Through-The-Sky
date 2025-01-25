using UnityEngine;

public class Death : MonoBehaviour
{
    public ParticleSystem collisionEffect; // ใส่ Particle System ที่ต้องการเล่น
    public AudioClip collisionSound;       // ใส่ AudioClip ที่ต้องการเล่น

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ตรวจสอบว่าชนกับ Fish หรือไม่
        if (collision.gameObject.CompareTag("Fish"))
        {
            // เล่น Particle Effect ที่ตำแหน่งของ Player
            ParticleSystem effect = Instantiate(collisionEffect, transform.position, Quaternion.identity);
            effect.Play(); // เริ่มเล่น Particle Effect

            // เล่นเสียงโดยใช้ PlayClipAtPoint
            if (collisionSound != null)
            {
                AudioSource.PlayClipAtPoint(collisionSound, transform.position);
            }

            // ปิดการทำงานของ Player ชั่วคราว
            gameObject.SetActive(false);
            playerscript.dead++;
            playerscript.ready = true;

            Debug.Log(playerscript.dead);
        }
    }
}
