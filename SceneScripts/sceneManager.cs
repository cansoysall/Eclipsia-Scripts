using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public LoadingScreen loadingScreen;
    public GameObject Loading;
    float elapsedTime;

    public void gotoGame()
    {
        SceneManager.UnloadScene(SceneData.mainMenu);
        SceneManager.LoadScene(SceneData.gameScene);
    }

    public void gotoMenuFromFirst()
    {
        SceneManager.UnloadScene(SceneData.firstScene);
        SceneManager.LoadScene(SceneData.mainMenu);
    }
    public void gotoMenuFromGame()
    {
        SceneManager.UnloadScene(SceneData.gameScene);
        SceneManager.LoadScene(SceneData.mainMenu);
    }
}
