using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void Start()
    {
        //nesneyi yok etmek, belli bir süre sonra yok etmek
        //to destroy the object, to destroy after a certain time

        Destroy(gameObject,2);

        //script dosyasýný silmek
        //delete script file in object

        Destroy(this);

        //objeye ait belirli bir componenti silmek..
        //Deleting a specific component of the object..

        Destroy(GetComponent<CapsuleCollider>());

    }

    void Update()
    {
        
    }
}
