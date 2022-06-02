using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addComponent : MonoBehaviour
{
    void Start()
    {
        //bir durum sonucunda ihtiyac duyulan componenti ekleme ve özelliklerini deðiþtirmek
        //add the component needed as a result of a situation and change its properties

        Rigidbody addRigidbody = gameObject.AddComponent<Rigidbody>() as Rigidbody;
        addRigidbody.isKinematic = true;

        //another method

        SphereCollider addSpehereCollider = gameObject.AddComponent(typeof(SphereCollider)) as SphereCollider;
        addSpehereCollider.isTrigger = true;






    }

    void Update()
    {
        
    }
}
