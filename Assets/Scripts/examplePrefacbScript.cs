using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examplePrefacbScript : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject,3f); //3saniyede bir olu�turulan objeyi yok ediyoruz
    }

    void Update()
    {
        transform.Translate(Vector3.forward); // obje olu�tuktan sonra verdi�imiz y�nde ilerliyor..
        
    }
}
