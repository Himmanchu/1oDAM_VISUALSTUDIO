using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSigue : MonoBehaviour
{
    //Referencia del objeto a seguir
    public GameObject objetivo;

    //Diferencia de posición respecto al objetivo
    public Vector3 desfase;

    // Start is called before the first frame update
    void Start()
    {
        //Conseguir el valor inicial del desfase
        //aplicando la distancia desde el jugador a la cámara
        desfase = this.transform.position - objetivo.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Actualizar la posición de la cámara
        this.transform.position = objetivo.transform.position + desfase;
    }
}
