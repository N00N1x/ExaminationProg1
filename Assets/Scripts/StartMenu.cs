using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Ladda nästa scen. Du måste ha lagt till dina scener i bygginställningarna (File -> Build Settings).
        SceneManager.LoadScene("GameScene"); // Byt "GameScene" till namnet på din faktiska spelscen.
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
