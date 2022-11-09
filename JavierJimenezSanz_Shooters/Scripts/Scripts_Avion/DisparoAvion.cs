using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoAvion : MonoBehaviour
{
    //Ref Punto de disparo
    public GameObject pDisparo;
    //Ref flare
    public GameObject efectoOriginal;
    //Ref balas
    public GameObject balaOriginal;

    //Velocidad bala
    public float velBala;

    //Cadencia
    public float tiempoCadencia = 0.2f;
    private float nextshoot = 0;


    // Update is called once per frame
    void Update()
    {
        disparoAvion();
    }

    void disparoAvion()
    {

        if (Time.time > nextshoot)
        {
            //El siguiente disparo se podrá hacer cuando al tiempo se le sume la cadencia que hemos marcado
            nextshoot = Time.time + tiempoCadencia;


            // Ref de la bala prefab
            GameObject nuevaBala;

            nuevaBala = (GameObject)Instantiate(balaOriginal, pDisparo.transform.position, this.transform.rotation);

            // Damos velocidad a la bala obteniendo antes el rigid de la nueva bala

            Rigidbody rigidClon;

            rigidClon = nuevaBala.GetComponent<Rigidbody>();

            rigidClon.velocity = new Vector3(0, 0, -velBala * Time.deltaTime);
        }

     }

    }
