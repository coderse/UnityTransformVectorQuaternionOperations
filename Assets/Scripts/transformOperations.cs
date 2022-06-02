using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformOperations : MonoBehaviour
{


    void Start()
    {
        //ilgili objenin transformunu alma
        // get the transform of the related object
        Debug.Log(transform.position);
        Debug.Log(transform.rotation);
        Debug.Log(transform.localScale);


    }

    void Update()
    {
        //objemin transform de�erlerini (sa�a git sola git) nas�l yapar�m Translate k�sm� update'in i�erisinde
        //oldu�u i�in s�rekli de�i�imi sa�l�yor E�er bu metodu startda �al��t�rsayd�k bir kere gider dururdu.
        //how do I transform my object's transform values (go right go left)? 
        //Since the translate part is in the update, it provides constant change. 
        //If we had run this method on start, it would have gone once and stopped.
        transform.Translate(new Vector3(2f,5f,3f));
        // anl�k saniyede bir hareket i�in time.deltatime ekleriz
        // add time.deltatime for instantaneous movement per second
        transform.Translate(new Vector3(2f, 5f, 3f) * Time.deltaTime);
        // aradaki 5f h�z�n� belirlemize yar�yor
        // it is used to determine the 5f speed in between
        transform.Translate(new Vector3(2f, 5f, 3f)* 5f * Time.deltaTime);
        // kordinat verildi�i gibi direk y�n bilgiside verebiliriz.
        // We can give direct direction information as well as the coordinates.
        transform.Translate(Vector3.right * Time.deltaTime);
        transform.Translate(Vector3.left * Time.deltaTime);
        transform.Translate(Vector3.up * Time.deltaTime);
        transform.Translate(Vector3.back * Time.deltaTime);
        //e�er objenin kordinatlar�na 1 vereceksek One
        // if we are going to give 1 to the coordinates of the object One
        transform.Translate(Vector3.one * Time.deltaTime);
        //e�er objenin kordinatlar�na 0 vereceksek zero kullanabiliriz
        //if we are going to give 0 to the coordinates of the object we can use zero
        transform.Translate(Vector3.zero * Time.deltaTime);




    }
}
