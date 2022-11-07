using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EjemIADist : MonoBehaviour
{
    //Referencia del jugador
    public GameObject jugador;

    //Distancia de detección
    public float distDeteccion;

    //Referencia del componente navmeshagent
    public NavMeshAgent miAgente;

    // Start is called before the first frame update
    void Start()
    {
        //Obtenemos la referencia del componente
        miAgente = this.GetComponent<NavMeshAgent>();

        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direccion;
        direccion = jugador.transform.position - this.transform.position;

        //Condición de distancia
        if(direccion.magnitude < distDeteccion)
        {
            //En rango

            //seguir al jugador
            miAgente.SetDestination(jugador.transform.position);
        }

      


        
    }
}
