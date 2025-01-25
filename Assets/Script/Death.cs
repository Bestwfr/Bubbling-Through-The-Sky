using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public ParticleSystem collisionEffect; // ใส่ Particle System ที่ต้องการเล่น

    void OnCollisionEnter2D(Collision2D collision)
    {
        // ตรวจสอบว่าชนกับ Fish หรือไม่
        if (collision.gameObject.CompareTag("Fish"))
        {
            // เล่น Particle Effect ที่ตำแหน่งของ Player
            ParticleSystem effect = Instantiate(collisionEffect, transform.position, Quaternion.identity);
            effect.Play(); // เริ่มเล่น Particle Effect

            // ปิดการทำงานของ Player ชั่วคราว
            gameObject.SetActive(false);

            // รอจน Particle เล่นเสร็จ
            StartCoroutine(WaitForParticleAndRestart(effect));
        }
    }

    System.Collections.IEnumerator WaitForParticleAndRestart(ParticleSystem effect)
    {
        // รอจน Particle Effect เล่นเสร็จ
        while (effect.isPlaying)
        {
            yield return null; // รอเฟรมถัดไป
        }

        // รีเซ็ต Scene หลัง Particle Effect เล่นเสร็จ
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
