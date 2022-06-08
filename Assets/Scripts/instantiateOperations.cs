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
        /* Instantiate(olusacakObjem);  //oyun olu�tu�unda prefab olarak ekledi�imiz objeyi olu�turur - �ocuk obje olarak 
        Instantiate(olusacakObjem, transform);
        Instantiate(olusacakObjem, transform.position, transform.rotation);
        Instantiate(olusacakObjem, transform.position, Quaternion.identity); //pozisyon okey rotation yok
        Instantiate(olusacakObjem, new Vector3(2f,3f,5f), Quaternion.identity); //belli bi noktaya olustruyoruz
        Instantiate(olusacakObjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity); //x i al gerisini ben giricem demek
        //olu�an objeyi yakalad�k
        GameObject ornekObje = Instantiate(olusacakObjem, new Vector3(transform.position.x, 3f, 5f), Quaternion.identity); //belli bi noktaya olustruyoruz
        ornekObje.GetComponent<BoxCollider>().enabled = false; //yakalad�ktan sonra componentlerine eri�ebiliriz bu �ekilde de


         */


    }

    void Update()
    {
        //2 saniyede bir obje olu�turuyoruz

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
