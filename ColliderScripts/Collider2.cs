using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2 : MonoBehaviour
{
    [SerializeField] public AudioSource _source;
    public AudioClip _clip;

    public CharacterProgress CP;

    void Start()
    {
        CP = new CharacterProgress();
    }


    void ColliderAction()
    {
        if (CP.getStage() == 1)
        {
            PlayEvent();
            CP.nextStage();
        }
    }

    void PlayEvent()
    {
        _source.PlayOneShot(_clip);
    }
}