using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class inheritor : MonoBehaviour
{
    public NavMeshAgent Agent;

    public Transform player, place;

    public void thing()
    {
        print("sauce");
        GameObject played = GameObject.Find("Main Character");
        print("balls");
        player = played.GetComponent<Transform>();
        print("real");
        Agent = GetComponent<NavMeshAgent>();
        print("sus");
        GameObject placed = GameObject.Find("place");
        place = placed.GetComponent<Transform>(); 
    }

    public void enemyMov()
    {




        NavMeshHit hit;
        bool navigering = NavMesh.SamplePosition(player.position, out hit, 2f, NavMesh.AllAreas);
        print(navigering);

        print(navigering);
        if (navigering)
        {
            Agent.destination = player.position;
        }
        else
        {
            Agent.destination = place.position;
        }


    }
}
