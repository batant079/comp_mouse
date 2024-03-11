using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class murder : MonoBehaviour
{
    Movement mov;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            print("s");
            mov.restart();
        }

    }
}
