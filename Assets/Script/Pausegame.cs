using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // ลาก GameObject ของเมนูหยุดเกมมาใส่ที่นี่
    public Button pauseButton; // ปุ่มหยุดเกม
    public Button resumeButton; // ปุ่มเล่นต่อ

    private bool isPaused = false; // สถานะของเกม (หยุด/ไม่หยุด)

    void Start()
    {
        // ซ่อนเมนูและปุ่มเล่นต่อเมื่อเริ่มต้น
        pauseMenuUI.SetActive(false);
        resumeButton.gameObject.SetActive(false);

        // กำหนด Event สำหรับปุ่ม
        pauseButton.onClick.AddListener(PauseGame);
        resumeButton.onClick.AddListener(ResumeGame);
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0; // หยุดเวลา
        pauseMenuUI.SetActive(true); // แสดงเมนูหยุดเกม
        resumeButton.gameObject.SetActive(true); // แสดงปุ่มเล่นต่อ
        pauseButton.gameObject.SetActive(false); // ซ่อนปุ่มหยุดเกม
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1; // เริ่มเวลาใหม่
        pauseMenuUI.SetActive(false); // ซ่อนเมนูหยุดเกม
        resumeButton.gameObject.SetActive(false); // ซ่อนปุ่มเล่นต่อ
        pauseButton.gameObject.SetActive(true); // แสดงปุ่มหยุดเกม
    }

    void OnDestroy()
    {
        // ลบ Listener เมื่อ Object ถูกทำลาย
        pauseButton.onClick.RemoveListener(PauseGame);
        resumeButton.onClick.RemoveListener(ResumeGame);
    }
}
