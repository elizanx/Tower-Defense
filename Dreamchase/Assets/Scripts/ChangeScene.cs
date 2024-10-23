using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public string SceneName;
    public void changeScene()
    {
        SceneManager.LoadScene("DreamChase");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene("DreamChase");
    }
    public void MainScreen()
    {
        SceneManager.LoadScene("MainScreen");
    }

    
}
