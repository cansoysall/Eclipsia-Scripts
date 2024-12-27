using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public Image soundEffectsOn;
    public Image soundEffectsOff;
    public static int index = 0;
    public static bool isOn;

    void Update()
    {
        if (index == 1)
        {
            isOn = false;
            //Debug.Log(isOn);
            soundEffectsOn.gameObject.SetActive(false);
            soundEffectsOff.gameObject.SetActive(true);
        }

        if (index == 0)
        {
            isOn = true;
            //Debug.Log(isOn);
            soundEffectsOff.gameObject.SetActive(false);
            soundEffectsOn.gameObject.SetActive(true);
        }
    }

    public void ON()
    {
        index = 1;
        soundEffectsOff.gameObject.SetActive(true);
        soundEffectsOn.gameObject.SetActive(false);
    }

    public void OFF()
    {
        index = 0;
        soundEffectsOn.gameObject.SetActive(true);
        soundEffectsOff.gameObject.SetActive(false);
    }
}
