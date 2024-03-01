using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechanger : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other)
    {
        print(other);

        if (other.gameObject.CompareTag("Doors"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
