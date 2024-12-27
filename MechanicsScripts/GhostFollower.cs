using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class GhostFollower : MonoBehaviour
{
    public void GhostSpawn()
    {
        //spawns the ghost
        Debug.Log("Ghost spawn");
    }

    public void GhostDeSpawn()
    {
        //de-spawns the ghost
        Debug.Log("Ghost De_Spawn");
    }
}