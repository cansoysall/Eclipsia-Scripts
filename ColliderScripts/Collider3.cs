using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider3 : MonoBehaviour
{
    [SerializeField] public AudioSource _source;
    public AudioClip ghostSound;
    public CharacterProgress CP;
    public GhostFollower GhostFollower;

    void Start()
    {
        CP = new CharacterProgress();
        GhostFollower = new GhostFollower();
    }

    void ColliderAction()
    {
        if (CP.getStage() == 2)
        {
            PlayEvent();
            CP.nextStage();
        }
    }

    void PlayEvent()
    {
        _source.PlayOneShot(ghostSound);
        GhostFollower.GhostSpawn();
    }
}