using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh_ : MonoBehaviour
{

    NavMeshAgent Agent;
   public Transform player, place;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshHit hit;
        bool navigering = NavMesh.SamplePosition(player.position, out hit, 1f, NavMesh.AllAreas);


        print(navigering);
        if(navigering)
        {
            Agent.destination = player.position;
        }
        else
        {
            Agent.destination = place.position;
        }




    }
}
