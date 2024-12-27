using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youSurePopUp : MonoBehaviour
{
    public GameObject youSurePanel;
    public sceneManager manager;

    public void OpenedThePopUp()
    {
        youSurePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void PressedToYes()
    {
        manager.gotoMenuFromGame();
        youSurePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void PressedToNo()
    {
        youSurePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
