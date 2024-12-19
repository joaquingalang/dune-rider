using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    void Update()
    {
        // Loads play area once the space bar has been pressed
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("Play Area");
        }
    }
}
