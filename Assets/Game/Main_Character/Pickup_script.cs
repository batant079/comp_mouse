using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Pickup_script : MonoBehaviour
{
    public Transform obj;
    public bool ispicked;
    public bool ispickable;
    public Transform player;
    public LayerMask layered;
    public RaycastHit hit;
    public int timed = 0;
    bool candrop;
    

    private void Start()
    {
      
    }
    private void Update()
    {
        ispickable = Physics.Raycast(transform.position, Vector3.forward, out hit,2f, layered);

        print(ispickable);


        if(ispickable && Input.GetKeyDown(KeyCode.E) && ispicked == false )
        {
            print("suss");
            pickitem();
            
            StartCoroutine(wait(1));

           

            
            


        }
       

        if(ispicked)
        {
            obj.position = player.transform.position;
            obj.rotation = player.transform.rotation;
        }
      
        if(ispicked && Input.GetKeyDown(KeyCode.E) && candrop)
        {
            dropitem();
            candrop = false;
            
            timed = 0;
            print(timed);
        }
            
       
        
    }

    

    private void pickitem()
    {
        ispicked = true;
        obj = hit.transform;
        obj.position = player.transform.position;
        
        

        
    }

    private IEnumerator wait(int waitTime)
    {
        
            yield return new WaitForSeconds(waitTime);

            candrop = true;
            
        
    }


    private void dropitem()
    {
        ispicked = false;
    }
}
