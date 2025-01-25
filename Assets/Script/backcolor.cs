using UnityEngine;
using UnityEngine.UI;

public class backcolor : MonoBehaviour
{
    void Update()
{
    if (Input.GetKeyDown(KeyCode.K)) // Press "K" to simulate player death
    {
        FindObjectOfType<BackgroundMusic>().PlayDeathSound();
    }
}


}
