using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    // �ѧ��ѹ����Ѻ����¹�˹�� Main Menu
    public void GoToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("mainmenu"); // ���� Scene ����ͧ�������¹�
    }
}
