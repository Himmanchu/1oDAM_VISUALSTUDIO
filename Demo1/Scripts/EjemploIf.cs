using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploIf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        int vida;
        vida = 5;

        if (vida > 0)
        {
            Debug.Log("Estoy vivo");
        }
        else
        {
            Debug.Log("Estoy muerto");


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
