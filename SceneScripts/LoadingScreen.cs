using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadingScreen : MonoBehaviour
{
    public GameObject Loading;
    float elapsedTime;

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 15)
        {
            Loading.SetActive(false);
        }
    }


}
