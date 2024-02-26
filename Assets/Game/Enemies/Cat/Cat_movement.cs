using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.AI;

public class Cat_movement : MonoBehaviour
{

    NavMeshAgent agent;
    public Transform Player, spawn;


    private void Start()
    {


    }

    private void Update()
    {
        RaycastHit hit;


        if (Physics.Linecast(transform.position, Player.position))
        {
            agent.destination = spawn.position;
            
        }
        else
        {
            agent.destination = Player.position;
        }
    }
}
