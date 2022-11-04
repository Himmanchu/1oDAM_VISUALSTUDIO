using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaLlave : MonoBehaviour
{
    //Creamos una variable booleana para saber si tenemos o no la llave
    public bool tengoLlave;


    //Detecta colisión traspasable
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Llave") { 

        //Obtener llave de forma lógica
        tengoLlave = true;

        //La llave desaparece
        Destroy(other.gameObject);

            Debug.Log("Tienes una llave");
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        //Detectar si es la puerta
        if(other.gameObject.tag == "Door"  && tengoLlave==true)
        {

            //Condición de si tengo la llave
            //if (tengoLlave == true)
            //{
                //Abres la puerta
              //  Destroy(other.gameObject);

                Debug.Log("Pasas al siguiente nivel");
            }

        }


    }
