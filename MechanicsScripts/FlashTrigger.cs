using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashTrigger : MonoBehaviour
{
    public FlashLight flash;
    void Start()
    {
        flash = new FlashLight();
    }
    void GetItem()
    {
        //Debug.Log("Got Flash");
        flash.getFlash();
        this.gameObject.SetActive(false);
    }

}