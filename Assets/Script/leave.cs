using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    // �ѧ��ѹ����Ѻ����¹�˹�� Main Menu
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("mainmenu"); // ���� Scene ����ͧ�������¹�
    }
}
