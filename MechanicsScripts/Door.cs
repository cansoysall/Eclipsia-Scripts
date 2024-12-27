using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System.Threading;

public class Door : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.O))
        {

            doorOpen();

        }


        if (Input.GetKey(KeyCode.P))
        {

            doorClose();
            
        }

    }



    void doorOpen()
    {
        transform.rotation = Quaternion.Euler(-90, 90, 90);
        door = true;
    }

    void doorClose()
    {
        transform.rotation = Quaternion.Euler(-90, 90, 180);
        door = false;
    }

    void doorChange() {

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
