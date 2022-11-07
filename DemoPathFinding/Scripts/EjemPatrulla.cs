using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EjemPatrulla : MonoBehaviour
{

    //Puntos de patrulla
    public GameObject p1;
    public GameObject p2;

    public int destActual;

    //Referencia navmeshagent
    public NavMeshAgent miAgente;
    public float margen = 1;
    public GameObject jugador;
    public float rango = 4;
    public float anguloVista = 45;

    // Start is called before the first frame update
    void Start()
    {
        miAgente = this.GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        Patrulla();
        DetectarAlPlayer();

    }

    void DetectarAlPlayer()
    {
        //DETECTAR AL PLAYER

        Vector3 distPlayer = jugador.transform.position - this.transform.position;       //vector del player a la IA
        if (distPlayer.magnitude < rango)                                                //Comparar tamaño del vector con rango de dectección
        {
            //Mirar la línea de visión
            RaycastHit resultadoRay;

            if (Physics.Raycast(this.transform.position, distPlayer, out resultadoRay, 20))
            {
                //Rayo colisiona con algo
                if (resultadoRay.transform.tag == "Player")                             //Que tiene línea de visión
                {
                    //Mirar el ángulo
                    float angulo = Vector3.Angle(this.transform.forward, distPlayer);

                    //Mirar si estamos dentro del ángulo del cono
                    if (angulo < anguloVista)
                    {
                        miAgente.SetDestination(jugador.transform.position);                //Ir al jugador como nuevo destino
                    }
                }

            }

        }
    }

    void Patrulla()
    {
        //Detectar la distancia que falta al destino
        //Distancia al destino

        Vector3 dist = this.transform.position - miAgente.destination;

        if (dist.magnitude < margen)
        {
            //Llegamos al destino
            if (destActual == 1)
            {
                //Actualizar destino
                destActual = 2;
                //Mandar al punto 2
                miAgente.SetDestination(p2.transform.position);
            }
            else
            {
                destActual = 1;
                //Mandar al punto 1
                miAgente.SetDestination(p1.transform.position);
            }
        }

    }

}
