using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrulla : MonoBehaviour
{

    //Puntos de patrulla
    public GameObject p1;
    public GameObject p2;

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
        PatrullaEnemigo1();
        DetectarPlayer();

    }

    void PatrullaEnemigo1()
    {
        //Distancia que falta al destino
        Vector3 dist = this.transform.position - miAgente.destination;
        if (dist.magnitude < margen)
        {
            //Llegamos al destino
            if (destActual == 1)
            {
                //Actualizamos destino
                destActual = 2;
            }
            else
            {
                destActual = 1;
            }
        }

        if (destActual == 1)
        {
            //Mandar al punto1
            miAgente.SetDestination(p1.transform.position);
        }
        else
        {
            miAgente.SetDestination(p2.transform.position);
        }
    }

    void DetectarPlayer()
    {
        Vector3 distPlayer = player.transform.position - this.transform.position;   //Distancia del jugador al enemigo

        if (distPlayer.magnitude<rango)              //Comparar tamaño del vector con rango de detección
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