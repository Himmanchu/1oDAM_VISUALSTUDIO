using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrullaEspecial : MonoBehaviour
{

    public NavMeshAgent miAgent;

    //Ref jugador
    public GameObject player;

    //Variables de disparo
    public float rango = 5;
    public GameObject balasE;
    public GameObject enemigo;
    public float anguloVista = 45;

    //Cadencia disparo
    public float TiempoCadencia = 1;
    private float nextshoot = 0;


    // public float rango = 6;

    // Start is called before the first frame update
    void Start()
    {
        miAgent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        DisparoEnemigoEspecial();

    }

    void DisparoEnemigoEspecial()
    {
        Vector3 distPlayer = player.transform.position - this.transform.position;   //Distancia del jugador al enemigo

        miAgent.SetDestination(player.transform.position);                      //Ir a por el jugador

        if (distPlayer.magnitude < rango && Time.time > nextshoot)              //Comparar tamaño del vector con rango de detección y añadir cadencia disparo
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
                        Instantiate(balasE, enemigo.transform.position, this.transform.rotation);

                        //El siguiente disparo se podrá hacer cuando al tiempo se le sume la cadencia que hemos marcado
                        nextshoot = Time.time + TiempoCadencia;
                    }
                }
            }
        }

    }
}
