using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnOff : MonoBehaviour
{
    [SerializeField] public AudioSource _source;
    public AudioClip _clip;


    public void Update()
    {
        if (Switch.index == 0)
        {
            _source.mute = false;
        }

        if (Switch.index == 1)
        {
            _source.mute = true;
        }
    }

}