using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string SceneName;

    void LoadTheScene()
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Additive); 
    }
    private void Quitla()
    {
        Application.Quit();
    }
}
