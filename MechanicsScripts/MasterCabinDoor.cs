using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterCabinDoor : MonoBehaviour
{
    public static bool isDoorOpen;

    static bool cardVerified;
    bool door;


    void Start()
    {
        cardVerified = false;
        door = false;
        isDoorOpen = false;
    }

    public void verifyCard()
    {
        cardVerified = true;
    }


    void doorOpen()
    {
        transform.rotation = Quaternion.Euler(-90, 90, 0);
        door = true;
        isDoorOpen = true;

    }

    void doorClose()
    {
        transform.rotation = Quaternion.Euler(-90, 90, -90);
        door = false;
    }

    void doorChange()
    {
        if (!cardVerified)
        {
            return;
        }

        if (door)
        {
            doorClose();
        }
        else
        {
            doorOpen();
        }

    }
    public bool DoorOpened()
    {
        return isDoorOpen;
    }
}