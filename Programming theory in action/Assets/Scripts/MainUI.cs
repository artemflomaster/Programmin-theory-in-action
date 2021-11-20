using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainUI : MonoBehaviour
{
    public void RestartScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void ExitTheGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
      Application.Quit();
#endif
    }




}
