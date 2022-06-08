using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examplePrefacbScript : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject,3f); //3saniyede bir oluþturulan objeyi yok ediyoruz
    }

    void Update()
    {
        transform.Translate(Vector3.forward); // obje oluþtuktan sonra verdiðimiz yönde ilerliyor..
        
    }
}
