using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip backgroundMusic; // Drag & drop your MP3 file here
    private AudioSource audioSource;

    void Start()
    {
        // สร้าง AudioSource แบบไดนามิก
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        audioSource.loop = true;  // เปิดใช้งานการเล่นแบบวนลูป
        audioSource.volume = 0.5f; // กำหนดระดับเสียง (0.0 - 1.0)
        audioSource.Play();       // เริ่มเล่นเพลง
    }
}
