using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaternion : MonoBehaviour
{
    public Transform hedef1;

    void Start()
    {

        //transform.rotation = Quaternion.Euler(90, 0, 0); //rotasyonunu deðiþtiriyor.

        //Çok önemli komut bunu yazdýðýmýzda objenin rotationunu sýfýrlar dönüþ yok rotation yok
        //varsa bunlar sýfýrlanýr.
        transform.rotation = Quaternion.identity;

    }

    void Update()
    {


        //vectordeki gibi kendi ekseninde döndürmeye yarýyor
        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);

        //nokta atýþý çözüm, bir farklý þekilde objeyi takip etme

        Vector3 fark = hedef1.position - transform.position;

        transform.rotation = Quaternion.LookRotation(fark, Vector3.up);

        transform.rotation = Quaternion.Inverse(hedef1.rotation); // objenin rotasyonlarýný taklik etme gibi düþüün



        

    }
}
