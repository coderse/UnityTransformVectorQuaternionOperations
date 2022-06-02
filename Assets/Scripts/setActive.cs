using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour
{

    //objenin ekranda aktifliðini kapatmak..

    void Start()
    {
        gameObject.SetActive(false);


        //objenin durumunu console kýsmýna yazmak..
        if (gameObject.activeSelf)
        {
            Debug.Log(gameObject.activeSelf);

        }


        //Hiyerarþi kýsmýnda Objelerin türüne göre arama..

        Camera cam = (Camera)FindObjectOfType(typeof(Camera));

        if (cam)
        {
            Debug.Log("evet kamera bulunuyor");
        }



        


        
    }

    void Update()
    {
        
    }
}
