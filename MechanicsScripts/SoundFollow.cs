using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SoundFollow : MonoBehaviour
{


    NavMeshAgent agent;
    GameObject chara;

    public MasterCabinDoor MCD;

    void Start()
    {
        MCD = new MasterCabinDoor();
        agent = GetComponent<NavMeshAgent>();
        chara = GameObject.FindWithTag("Player");
        agent.SetDestination(transform.position);


    }


    void Update()
    {

        transform.rotation = Quaternion.Euler(-90, 0, 0);


        if (MCD.DoorOpened())
        {

            agent.SetDestination(chara.transform.position);

        }

    }
}