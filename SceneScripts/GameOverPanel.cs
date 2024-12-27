using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public GameObject SettingsPanel;
    public static bool isActive;

    public void Settings()
    {
        SettingsPanel.SetActive(true);
        Time.timeScale = 0;
        isActive = true;
    }

    public void GoingBackToGame()
    {
        SettingsPanel.SetActive(false);
        Time.timeScale = 1;
        isActive = false;
    }
}