using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorStaticMet : MonoBehaviour
{
    //static Methodlar..

    public Transform hedef1;
    public Transform hedef2;

    private float baslangiczamani;


    void Start()
    {

        baslangiczamani = Time.time;

        /*
                Time.time -> oyun ba�lad�ktan sonra ge�en zaman� bize verir , ne kadar zaman ge�ti�ini verir
                Time.deltaTime -> kare h�z� olarak ilerliyor frame h�z�
                Time.timeScale -> oyunu yava�lat�p h�zland�rma gibi d���n.. durduradabiliriz.

         */
      
        
    }

    void Update()
    {
        /*
         
        //----------------------------------------------------------
         
         //lerp 
        // objenin belirlenen bir noktadan belirlenen di�er noktaya gitmesini sa�l�yor

        transform.position = Vector3.Lerp(hedef1.position, hedef2.position, (Time.time - baslangiczamani) * .3f);


          
        //----------------------------------------------------------
        
        //Distance iki objenin aras�ndaki distance de�erini verir bize...
        //Herhangi iki objenin birbirine yakla�mas�n� kontrol etmek istiyorsak kullanabiliriz..

        float fark = Vector3.Distance(hedef1.position, transform.position);
        Debug.Log("Fark �udur : " + fark); 
        
        //----------------------------------------------------------
       
        //angle - iki objenin aras�ndaki a��y� bulmam�za yar�yor

        Vector3 mesafe = hedef1.position - transform.position;

        float angle = Vector3.Angle(mesafe, transform.up);

        Debug.Log(angle);

        if (angle < 5f)
            Debug.Log("A�� sa�land�");
        

        //----------------------------------------------------------

        */



    }
}
