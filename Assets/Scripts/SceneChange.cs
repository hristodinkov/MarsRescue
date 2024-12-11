using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void LoadScene(int pSceneIndex)
    {
        SceneManager.LoadScene(pSceneIndex);
    }

    public void LoadScene(string pSceneName)
    {
        SceneManager.LoadScene(pSceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
