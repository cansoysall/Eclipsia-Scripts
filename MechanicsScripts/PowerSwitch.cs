using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.Assertions;

public class PowerSwitch : MonoBehaviour
{
    public GameObject parent;
    public bool isPressed;
    public LightsOff lights;

    private void Start()
    {
        lights = new LightsOff();
        isPressed = false;
    }
    void SwitchOn()
    {
        isPressed = true;    
        transform.RotateAround(parent.transform.position, Vector3.forward, -90);
        lights.allLightsOn();
    }

    void SwitchOff()
    {
        transform.RotateAround(parent.transform.position, Vector3.forward, 90);
        lights.allLightsOff();
    }
}