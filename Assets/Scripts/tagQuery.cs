using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagQuery : MonoBehaviour
{
    void Start()
    {
        //tag query..
        if (gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy is here");
        }
        else
        {
            Debug.Log("no enemies");
        }
        
    }

    void Update()
    {
        
    }
}
