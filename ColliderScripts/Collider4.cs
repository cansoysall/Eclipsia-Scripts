using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider4 : MonoBehaviour
{
    [SerializeField] public AudioSource _source;
    public AudioClip horrificSound;
    public CharacterProgress CP;

    void Start()
    {
        CP = new CharacterProgress();
    }

    void ColliderAction()
    {
        if (CP.getStage() == 3)
        {
            PlayEvent();
            CP.nextStage();
        }
    }

    void PlayEvent()
    {
        _source.PlayOneShot(horrificSound);
    }
}