using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{




    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.SendMessage("onGround");
        }

    }


    private void OnCollisionExit(Collision collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {

            collision.gameObject.SendMessage("offGround");

        }

    }


}
