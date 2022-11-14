using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EjemButtonUI : MonoBehaviour
{
    public GameObject objetoConImagen;
    public bool activo = true;


    public void clicBoton()
    {
        Debug.Log("Hola, pulsaste el botón");
        activo = !activo;

        objetoConImagen.SetActive(activo);

    }
}
