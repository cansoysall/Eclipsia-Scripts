using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider1 : MonoBehaviour
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
        if (CP.getStage() == 0)
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