using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{

    public GameObject ProyectilOriginal;

    //Referencia del gameobject desde donde se dispara
    public GameObject PuntoDisparo;

    //Cadencia disparo
    public float TiempoCadencia = 2;
    private float nextshoot = 0;

    // Update is called once per frame
    void Update()
    {
        //Hacemos el input para que al pulsar dispare y comenzamos a contar el tiempo para el siguiente disparo
        if(Input.GetKeyDown(KeyCode.Space) && Time.time >nextshoot)

        {
            //Crear clones de la bala
            Instantiate(ProyectilOriginal, PuntoDisparo.transform.position, PuntoDisparo.transform.rotation);

            //El siguiente disparo se podrá hacer cuando pase al tiempo se le sume la cadencia que hemos marcado

            nextshoot = Time.time + TiempoCadencia;
            
        }

        
    

    }
}
