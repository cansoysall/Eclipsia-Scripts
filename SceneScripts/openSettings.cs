using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class openSettings : MonoBehaviour
{

    public SettingsPopUpScript SettingsPopUpScript; //With the help of this script, we can either open or close the settings when the key 'M' is pressed. 
    public GameOverPanel GameOverPanel;
    [SerializeField] UnityEvent onTriggerEnter;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (SettingsPopUpScript.isActive)
            {
                SettingsPopUpScript.GoingBackToGame();
            }
            else
            {
                SettingsPopUpScript.Settings();
            }

        }
        void OnTriggerEnter(Collider other)//When the girl collides us, the Game Over Panel pops-up
        {

            if (GameOverPanel.isActive)
            {
                GameOverPanel.GoingBackToGame();
            }
            else
            {
                GameOverPanel.Settings();
            }
        }
    }
}
