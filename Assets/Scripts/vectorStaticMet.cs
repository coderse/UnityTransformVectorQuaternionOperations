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
                Time.time -> oyun baþladýktan sonra geçen zamaný bize verir , ne kadar zaman geçtiðini verir
                Time.deltaTime -> kare hýzý olarak ilerliyor frame hýzý
                Time.timeScale -> oyunu yavaþlatýp hýzlandýrma gibi düþün.. durduradabiliriz.

         */
      
        
    }

    void Update()
    {
        /*
         
        //----------------------------------------------------------
         
         //lerp 
        // objenin belirlenen bir noktadan belirlenen diðer noktaya gitmesini saðlýyor

        transform.position = Vector3.Lerp(hedef1.position, hedef2.position, (Time.time - baslangiczamani) * .3f);


          
        //----------------------------------------------------------
        
        //Distance iki objenin arasýndaki distance deðerini verir bize...
        //Herhangi iki objenin birbirine yaklaþmasýný kontrol etmek istiyorsak kullanabiliriz..

        float fark = Vector3.Distance(hedef1.position, transform.position);
        Debug.Log("Fark þudur : " + fark); 
        
        //----------------------------------------------------------
       
        //angle - iki objenin arasýndaki açýyý bulmamýza yarýyor

        Vector3 mesafe = hedef1.position - transform.position;

        float angle = Vector3.Angle(mesafe, transform.up);

        Debug.Log(angle);

        if (angle < 5f)
            Debug.Log("Açý saðlandý");
        

        //----------------------------------------------------------

        */



    }
}
