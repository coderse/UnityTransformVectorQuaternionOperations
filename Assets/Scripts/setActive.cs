using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour
{

    //objenin ekranda aktifli�ini kapatmak..

    void Start()
    {
        gameObject.SetActive(false);


        //objenin durumunu console k�sm�na yazmak..
        if (gameObject.activeSelf)
        {
            Debug.Log(gameObject.activeSelf);

        }


        //Hiyerar�i k�sm�nda Objelerin t�r�ne g�re arama..

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
