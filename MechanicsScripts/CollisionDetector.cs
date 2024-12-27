using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    float targetTime;
    Ray ray;
    [SerializeField] LayerMask mask;
    public FlashLight myLight;
    void Start()
    {
        targetTime = 0;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            interact();
        }
    }

    void interact()
    {
        if (Time.time < targetTime)
        {
            return;
        }

        ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, 5f, mask))
        {

            Collider col = hit.collider;

            //Debug.Log(col.gameObject.name);

            switch (col.gameObject.tag)
            {
                case ("Door"):
                    {
                        col.gameObject.SendMessage("doorChange");
                        //Debug.Log("Door Hit");
                    }
                    break;

                case ("Switch"):
                    {
                        col.gameObject.SendMessage("SwitchOn");
                        //Debug.Log("Switch");
                    }
                    break;

                case ("Item"): // some main objects are: access card, flash
                    {
                        col.gameObject.SendMessage("GetItem");
                        //Debug.Log(col.gameObject.name);
                    }
                    break;

                case ("CardReader"):
                    {
                        col.gameObject.SendMessage("ReadCard");
                    }
                    break;
            }
        }
        targetTime = Time.time + 0.2f;
    }
}