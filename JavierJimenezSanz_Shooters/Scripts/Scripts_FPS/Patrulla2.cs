using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrulla2 : MonoBehaviour
{

    //Puntos de patrulla
    public GameObject p3;
    public GameObject p4;

    public int destActual;


    //Referencia de navegación de los enemigos
    public NavMeshAgent miAgente;

    public float margen = 1;

    //Ref jugador
    public GameObject player;

    //Variables de disparo
    public float rango = 5;
    public GameObject balasE;
    public GameObject enemigo;
    public float anguloVista = 45;

    //Cadencia
    public float tiempoCadencia = 1;
    private float nextshoot = 0;


    // Start is called before the first frame update
    void Start()
    {
        miAgente = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        PatrullaEnemigo2();
        DetectarPlayer();
    }
    void PatrullaEnemigo2()
    {
        //Distancia que falta al destino
        Vector3 dist = this.transform.position - miAgente.destination;
        if (dist.magnitude < margen)
        {
            //Llegamos al destino
            if (destActual == 3)
            {
                //Actualizamos destino
                destActual = 4;
            }
            else
            {
                destActual = 3;
            }
        }

        if (destActual == 3)
        {
            //Mandar al punto3
            miAgente.SetDestination(p3.transform.position);
        }
        else
        {
            miAgente.SetDestination(p4.transform.position);
        }
    }

    void DetectarPlayer()
    {
        Vector3 distPlayer = player.transform.position - this.transform.position;   //Distancia del jugador al enemigo

        if (distPlayer.magnitude < rango)              //Comparar tamaño del vector con rango de detección
        {
            //Creo un Raycast para saber si el enemigo tiene visión con el player y puede dispararle
            RaycastHit resultadoRay;

            if (Physics.Raycast(this.transform.position, distPlayer, out resultadoRay, 20))
            {
                if (resultadoRay.transform.tag == "Player")  //Si tiene línea de visión hay que comprobar el ángulo
                {
                    //Miramos el ángulo
                    float angulo = Vector3.Angle(this.transform.forward, distPlayer);

                    if (angulo < anguloVista)
                    {
                        miAgente.SetDestination(player.transform.position);                      //Ir a por el jugador

                        if (Time.time > nextshoot)
                        {
                            //El siguiente disparo se podrá hacer cuando al tiempo se le sume la cadencia que hemos marcado
                            nextshoot = Time.time + tiempoCadencia;
                            Instantiate(balasE, enemigo.transform.position, this.transform.rotation);   //Enemigo dispara
                        }

                    }
                }
            }
        }
    }

}