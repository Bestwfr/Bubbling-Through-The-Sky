using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public void StartGame()
    {
        // ��Ŵ Scene �ͧ����ѡ
        SceneManager.LoadScene("1");
    }

    public void OpenSettings()
    {
        // �ʴ���õ�駤������ UI �ͧ���ٵ�駤��
        Debug.Log("Settings Menu Opened");
    }

    public void QuitGame()
    {
        // �͡�ҡ��
        Debug.Log("Game Quit");
        Application.Quit();
    }
}
