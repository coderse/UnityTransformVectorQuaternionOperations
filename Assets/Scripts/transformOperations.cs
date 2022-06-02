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
        //objemin transform deðerlerini (saða git sola git) nasýl yaparým Translate kýsmý update'in içerisinde
        //olduðu için sürekli deðiþimi saðlýyor Eðer bu metodu startda çalýþtýrsaydýk bir kere gider dururdu.
        //how do I transform my object's transform values (go right go left)? 
        //Since the translate part is in the update, it provides constant change. 
        //If we had run this method on start, it would have gone once and stopped.
        transform.Translate(new Vector3(2f,5f,3f));
        // anlýk saniyede bir hareket için time.deltatime ekleriz
        // add time.deltatime for instantaneous movement per second
        transform.Translate(new Vector3(2f, 5f, 3f) * Time.deltaTime);
        // aradaki 5f hýzýný belirlemize yarýyor
        // it is used to determine the 5f speed in between
        transform.Translate(new Vector3(2f, 5f, 3f)* 5f * Time.deltaTime);
        // kordinat verildiði gibi direk yön bilgiside verebiliriz.
        // We can give direct direction information as well as the coordinates.
        transform.Translate(Vector3.right * Time.deltaTime);
        transform.Translate(Vector3.left * Time.deltaTime);
        transform.Translate(Vector3.up * Time.deltaTime);
        transform.Translate(Vector3.back * Time.deltaTime);
        //eðer objenin kordinatlarýna 1 vereceksek One
        // if we are going to give 1 to the coordinates of the object One
        transform.Translate(Vector3.one * Time.deltaTime);
        //eðer objenin kordinatlarýna 0 vereceksek zero kullanabiliriz
        //if we are going to give 0 to the coordinates of the object we can use zero
        transform.Translate(Vector3.zero * Time.deltaTime);




    }
}
