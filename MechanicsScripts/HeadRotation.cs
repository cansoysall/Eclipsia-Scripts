using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public SettingsPopUpScript SettingsPopUpScript;
    // Start is called before the first frame update

    float sensitivity = 2f;

    Vector2 currentRotation = Vector2.zero;

    float minYAngle = -90;
    float maxYAngle = 90;
    

    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {


        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
        //currentRotation.x = Mathf.Clamp(currentRotation.x, -maxYAngle, maxYAngle);

        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
        transform.rotation = Quaternion.Euler(currentRotation.y, currentRotation.x, 0);

        Debug.Log(SettingsPopUpScript.isActive);

        if (!SettingsPopUpScript.isActive)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (SettingsPopUpScript.isActive)
        {
            Cursor.lockState = CursorLockMode.None;
        }



    }
}
