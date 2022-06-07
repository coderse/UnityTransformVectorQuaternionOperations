using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformOperations2 : MonoBehaviour
{
    /*public Transform hedef1;
    public Transform hedef2;*/

    void Start()
    {
        //dýþarýdan objenin pozisyonunu istediðimiz gibi ayarlayabiliyoruz
        //transform.position = new Vector3(2f, 3f, 5f); 

        //fakat sadece objenin bir kordinatýný deðiþtirmek istersek
        //transform.position.x dersek güncel x deðerini koru diyoruz
        //mevcut deeðerleri koruyoruz sadece y yi deðþiyoruz
        //transform.position = new Vector3(transform.position.x, 3f, transform.position.z);

        /* 
         * ismi belli olan bir objeyi bulup tüm componentlerine eriþebiliriz.
        GameObject aramasonuc = transform.Find("Cube").gameObject;
        aramasonuc.name = "Artýk Yeni Cube'um"; 
        */


        //çok objelerim arasýnda gezin ismi cube olan obji bulursan box colliderini kapa

        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).name == "Cube")
            {
                transform.GetChild(i).GetComponent<BoxCollider>().enabled = false;

            }
        }


        
    }

    void Update()
    {





        //hedef2.transform.LookAt(hedef1); // bir objenin bir objeyi takip etmesinin en temel hali


        //----------------------------------------------------

        //transform.Rotate(new Vector3(1f, 0f, 0f), Space.World); //dünya eksenine göre dönüyor
        //transform.Rotate(new Vector3(1f, 0f, 0f), Space.Self); //Kendi eksenine göre dönüyor

        //----------------------------------------------------

        // rotate bize objenin etrafýnda dönmesini saðlar 
        //transform.Rotate(new Vector3(2f, 9f, 9f));
        // dönme hýzýný ayarlama
        //transform.Rotate(new Vector3(2f, 9f, 9f)* Time.deltaTime * 5f);

        //----------------------------------------------------

        //transform.rotation // rotation bize bilgileri verir

        // transform.Translate(transform.forward); //dersek z yönünde dümdüz ilerler
    }
}
