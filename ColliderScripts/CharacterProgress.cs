using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CharacterProgress : MonoBehaviour
{
    private static int progress;

    void Start()
    {
        progress = 0;
    }

    public int getStage()
    {
        return progress;
    }

    public void nextStage()
    {
        progress++;
    }

    public void prevStage()
    {
        Assert.AreNotEqual(progress, 0);
        progress--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ProgressCollider")
        {
            other.gameObject.SendMessage("ColliderAction");
        }
    }
}