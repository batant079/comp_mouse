using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class murdered : MonoBehaviour
{

    private void Update()
    {
        transform.Rotate(Time.deltaTime * 9.3639892896f, 15 * Time.deltaTime, 9.3639892896f * Time.deltaTime);
        transform.Translate(transform.forward * 50 * Time.deltaTime);
    }

}
