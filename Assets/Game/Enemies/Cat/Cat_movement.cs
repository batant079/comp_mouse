using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.AI;

public class Cat_movement : MonoBehaviour
{
    public Transform Player;
    NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {

        agent = GetComponent<NavMeshAgent>();
        agent.destination = Player.position;
    }
}
