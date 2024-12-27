using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    static bool isTaken;
    public GameObject card;
    float time =0;
    MeshRenderer MeshRenderer;
    void Start()
    {
        MeshRenderer = GetComponent<MeshRenderer>();
        MeshRenderer.enabled = false;
        isTaken = false;
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (time > 5)
        {
            MeshRenderer.enabled = true;
        }
    }
    void takeCard()
    {
        isTaken = true;
        hideCard();
        Debug.Log("Card Taken");
    }

    public bool hasAccess()
    {
        return isTaken;
    }

    void GetItem()
    {
        takeCard();
    }

    public void hideCard()
    {
        card.SetActive(false);
    }

    public void showCard()
    {
        card.SetActive(true);
    }
}