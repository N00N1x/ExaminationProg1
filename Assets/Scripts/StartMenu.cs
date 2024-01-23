using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Ladda n�sta scen. Du m�ste ha lagt till dina scener i bygginst�llningarna (File -> Build Settings).
        SceneManager.LoadScene("GameScene"); // Byt "GameScene" till namnet p� din faktiska spelscen.
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
