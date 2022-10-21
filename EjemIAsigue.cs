using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemIAsigue : MonoBehaviour
{
    //Referencia del jugador
    public GameObject refJugador;


    // Start is called before the first frame update
    void Start()
    {
        //La posición del Enemigo
     
    }

    // Update is called once per frame
    void Update()
    {
        //Creamos un Vector3 que haga que el enemigo siga al jugador
        Vector3 direccion = refJugador.transform.position - this.transform.position;

        this.transform.Translate(direccion *Time.deltaTime);

    }
}
