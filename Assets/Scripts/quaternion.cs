using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaternion : MonoBehaviour
{
    public Transform hedef1;

    void Start()
    {

        //transform.rotation = Quaternion.Euler(90, 0, 0); //rotasyonunu de�i�tiriyor.

        //�ok �nemli komut bunu yazd���m�zda objenin rotationunu s�f�rlar d�n�� yok rotation yok
        //varsa bunlar s�f�rlan�r.
        transform.rotation = Quaternion.identity;

    }

    void Update()
    {


        //vectordeki gibi kendi ekseninde d�nd�rmeye yar�yor
        transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);

        //nokta at��� ��z�m, bir farkl� �ekilde objeyi takip etme

        Vector3 fark = hedef1.position - transform.position;

        transform.rotation = Quaternion.LookRotation(fark, Vector3.up);

        transform.rotation = Quaternion.Inverse(hedef1.rotation); // objenin rotasyonlar�n� taklik etme gibi d����n



        

    }
}
