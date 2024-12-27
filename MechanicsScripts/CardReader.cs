using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReader : MonoBehaviour
{
    public Card card;
    public MasterCabinDoor MCD;

    void Start()
    {
        card = new Card();
        MCD = new MasterCabinDoor();
    }

    void ReadCard()
    {
        if (card.hasAccess())
        {
            MCD.verifyCard();
        }
    }
}