using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateOperations : MonoBehaviour
{

    public GameObject olusacakObjem;
    private float zaman;

    void Start()
    {
        zaman = 0;
        /* Instantiate(olusacakObjem);  //oyun oluþtuðunda prefab olarak eklediðimiz objeyi oluþturur - çocuk obje olarak 
        Instantiate(olusacakObjem, transform);
        Instantiate(olusacakObjem, transform.position, transform.rotation);
        Instantiate(olusacakObjem, transform.position, Quaternion.identity); //pozisyon okey rotation yok
        Instantiate(olusacakObjem, new Vector3(2f,3f,5f), Quaternion.identity); //belli bi noktaya olustruyoruz
        Instantiate(olusacakObjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity); //x i al gerisini ben giricem demek
        //oluþan objeyi yakaladýk
        GameObject ornekObje = Instantiate(olusacakObjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity); //belli bi noktaya olustruyoruz
        ornekObje.GetComponent<BoxCollider>().enabled = false; //yakaladýktan sonra componentlerine eriþebiliriz bu þekilde de


         */


    }

    void Update()
    {
        //2 saniyede bir obje oluþturuyoruz

        if (zaman >=2)
        {
            Instantiate(olusacakObjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity);

            zaman = 0;


        }
        else
        {
            zaman += Time.deltaTime;
        }


    }
}
