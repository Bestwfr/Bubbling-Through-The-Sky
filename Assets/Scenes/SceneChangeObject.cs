using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTrigger2D : MonoBehaviour
{
    [Header("Scene Settings")]
    [Tooltip("ใส่ชื่อ Scene ที่ต้องการเปลี่ยนไป")]
    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ตรวจสอบว่า GameObject ที่เข้ามาเป็น Player หรือไม่
        if (collision.CompareTag("Player"))
        {
            // เปลี่ยน Scene
            if (!string.IsNullOrEmpty(sceneToLoad))
            {
                SceneManager.LoadScene(sceneToLoad);
                playerscript.dead = 0;
                Debug.Log(playerscript.dead);
            }
            else
            {
                Debug.LogWarning("ยังไม่ได้ใส่ชื่อ Scene ใน Inspector!");
            }
        }
    }
}
