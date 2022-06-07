using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformOperations2 : MonoBehaviour
{
    /*public Transform hedef1;
    public Transform hedef2;*/

    void Start()
    {
        //d��ar�dan objenin pozisyonunu istedi�imiz gibi ayarlayabiliyoruz
        //transform.position = new Vector3(2f, 3f, 5f); 

        //fakat sadece objenin bir kordinat�n� de�i�tirmek istersek
        //transform.position.x dersek g�ncel x de�erini koru diyoruz
        //mevcut dee�erleri koruyoruz sadece y yi de��iyoruz
        //transform.position = new Vector3(transform.position.x, 3f, transform.position.z);

        /* 
         * ismi belli olan bir objeyi bulup t�m componentlerine eri�ebiliriz.
        GameObject aramasonuc = transform.Find("Cube").gameObject;
        aramasonuc.name = "Art�k Yeni Cube'um"; 
        */


        //�ok objelerim aras�nda gezin ismi cube olan obji bulursan box colliderini kapa

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

        //transform.Rotate(new Vector3(1f, 0f, 0f), Space.World); //d�nya eksenine g�re d�n�yor
        //transform.Rotate(new Vector3(1f, 0f, 0f), Space.Self); //Kendi eksenine g�re d�n�yor

        //----------------------------------------------------

        // rotate bize objenin etraf�nda d�nmesini sa�lar 
        //transform.Rotate(new Vector3(2f, 9f, 9f));
        // d�nme h�z�n� ayarlama
        //transform.Rotate(new Vector3(2f, 9f, 9f)* Time.deltaTime * 5f);

        //----------------------------------------------------

        //transform.rotation // rotation bize bilgileri verir

        // transform.Translate(transform.forward); //dersek z y�n�nde d�md�z ilerler
    }
}
