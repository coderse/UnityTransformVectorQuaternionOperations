using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vectorProperties : MonoBehaviour
{
    Vector3 Position1;
    Vector3 Position2;

    void Start()
    {
        //bir objenin verilmi� uzunlu�unu yakalama
        Debug.Log(Vector3.Magnitude(transform.position));
        //bir objenin verilmi� uzunlu�un karesini yakalama
        Debug.Log(Vector3.SqrMagnitude(transform.position));

        Position1 = new Vector3(1f, 2f, 1f);
        Position2 = new Vector3(1f, 2f, 1f);

        //de�erlerimi string de�ere atayabilirim..

        Debug.Log(Position1.ToString());

        //vectorleri kar��la�t�r�yoruz.
        if (Equals(Position1, Position2))
        {
            Debug.Log("evet ayn�");
        }
        else
        {
            Debug.Log("Hay�r de�il");

        }

        //kesin sonu� alabilmek i�in. Kullanmak daha iyidir equals bazen hata verebiliyor.
        if (Position1==Position2)
        {
            Debug.Log("evet ayn�");
        }
        else
        {
            Debug.Log("Hay�r de�il");

        }
    }

    void Update()
    {
       

    }
}
