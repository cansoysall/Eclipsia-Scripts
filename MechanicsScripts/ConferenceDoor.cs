using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Threading;

public class ConferenceDoor : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject room;

    Rigidbody rb;

    bool door;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        door = false;
    }

    void doorOpen()
    {
        transform.rotation = Quaternion.Euler(-90, 90, 0);
        door = true;
    }

    void doorClose()
    {
        transform.rotation = Quaternion.Euler(-90, 90, -90);
        door = false;
    }

    void doorChange()
    {

        if (door)
        {
            doorClose();
        }
        else
        {
            doorOpen();
        }

    }
}