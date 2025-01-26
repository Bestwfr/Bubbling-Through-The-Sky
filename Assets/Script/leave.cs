using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    // ฟังก์ชันสำหรับเปลี่ยนไปหน้า Main Menu
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("mainmenu"); // ชื่อ Scene ที่ต้องการเปลี่ยนไป
    }
}
