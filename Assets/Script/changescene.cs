using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public void StartGame()
    {
        // โหลด Scene ของเกมหลัก
        SceneManager.LoadScene("1");
    }

    public void OpenSettings()
    {
        // แสดงการตั้งค่าหรือ UI ของเมนูตั้งค่า
        Debug.Log("Settings Menu Opened");
    }

    public void QuitGame()
    {
        // ออกจากเกม
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
