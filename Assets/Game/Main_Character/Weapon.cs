using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapon : MonoBehaviour
{
    public LayerMask mask;
    public float dmg;
    private bool canDmg;
    public float attackDuriation;
    private float timeSinceAttack;

    void Update()
    {
        timeSinceAttack += Time.deltaTime;
        if (timeSinceAttack > attackDuriation)
        {
            canDmg = false;
        }
    }

    public void Attack()
    {
        canDmg = true;
        timeSinceAttack = 0;
    }

    public void StopAttack()
    {
        canDmg = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (canDmg)
        {
            if (mask == (mask | (1 << other.gameObject.layer)))//if included in the mask
            {
                //badguy bg = other.GetComponentInParent<badguy>();
               // if (bg != null)
                {
                 //   bg.Damage(dmg);
                   // canDmg = false;
                }
            }
        }

    }
}
