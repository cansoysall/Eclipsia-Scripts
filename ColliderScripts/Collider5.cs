using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider5 : MonoBehaviour
{
    public CharacterProgress CP;

    public Card card;

    void Start()
    {
        CP = new CharacterProgress();
        card = new Card();
    }

    void ColliderAction()
    {

        if (CP.getStage() == 4)
        {
            PlayEvent();
            CP.nextStage();
        }
    }
    void PlayEvent()
    {
        card.showCard();
    }
}