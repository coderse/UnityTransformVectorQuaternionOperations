using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorProperties : MonoBehaviour
{
    Vector3 Position1;
    Vector3 Position2;

    void Start()
    {
        //bir objenin verilmiþ uzunluðunu yakalama
        Debug.Log(Vector3.Magnitude(transform.position));
        //bir objenin verilmiþ uzunluðun karesini yakalama
        Debug.Log(Vector3.SqrMagnitude(transform.position));

        Position1 = new Vector3(1f, 2f, 1f);
        Position2 = new Vector3(1f, 2f, 1f);

        //deðerlerimi string deðere atayabilirim..

        Debug.Log(Position1.ToString());

        //vectorleri karþýlaþtýrýyoruz.
        if (Equals(Position1, Position2))
        {
            Debug.Log("evet ayný");
        }
        else
        {
            Debug.Log("Hayýr deðil");

        }

        //kesin sonuç alabilmek için. Kullanmak daha iyidir equals bazen hata verebiliyor.
        if (Position1==Position2)
        {
            Debug.Log("evet ayný");
        }
        else
        {
            Debug.Log("Hayýr deðil");

        }
    }

    void Update()
    {
       

    }
}
