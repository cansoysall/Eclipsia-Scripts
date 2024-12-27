using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOff : MonoBehaviour
{

    public GameObject light;

    public void allLightsOff()
    {
        light.SetActive(false);
    }

    public void allLightsOn()
    {
        light.SetActive(true);
    }
}
