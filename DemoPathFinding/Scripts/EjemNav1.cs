using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EjemNav1 : MonoBehaviour
{

    //Referencia del agente de navegación del GameObject
    public NavMeshAgent miAgente;

    //Derstino al que debe ir la IA
    public GameObject dest;


    // Start is called before the first frame update
    void Start()
    {
     

        
    }

    // Update is called once per frame
    void Update()
    {
        //Indicamos un nuevo destino al agente
        miAgente.SetDestination(dest.transform.position);


    }
}
