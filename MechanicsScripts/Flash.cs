using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashLight : MonoBehaviour
{

    [SerializeField] Light lightObj;

    static bool hasFlash;
    static bool isOn;
    float targetTime;
    private void Start()
    {
        turnOff();
        hasFlash = false;
        isOn = false;
        targetTime = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F) && hasFlash)
        {
            switchLight();
        }
    }

    void turnOn()
    {
        lightObj.enabled = true;
        isOn = true;
    }


    void turnOff()
    {
        lightObj.enabled = false;
        isOn = false;
    }


    public void switchLight()
    {
        if (Time.time < targetTime)
        {
            return;
        }
        if (isOn)
        {
            turnOff();
        }
        else
        {
            turnOn();
        }

        targetTime = Time.time + 0.2f;
    }

    public void getFlash()
    {
        hasFlash = true;
        Debug.Log("Flash Active");
    }
}