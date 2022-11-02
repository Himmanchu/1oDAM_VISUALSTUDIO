using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{

    public GameObject balaOriginal;

    public float vel;

    public GameObject puntoCreacion;

    public GameObject flare;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Chequeamos el input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Disparar
            LanzarProyectil();


            //Creo humo al disparar
            Instantiate(flare, puntoCreacion.transform.position, this.transform.rotation);
        }


    }
    void LanzarProyectil()
    {
        //Obtener la referencia del clon recien creado
        GameObject nuevaBala;
        nuevaBala = (GameObject)Instantiate(balaOriginal, puntoCreacion.transform.position, this.transform.rotation);


        //Obtener la referencia de su Rigidbody
        Rigidbody rigidDelClon;
        rigidDelClon = nuevaBala.GetComponent<Rigidbody>();

        //Dar velocidad
        rigidDelClon.velocity = new Vector3(0, 2, vel);

    }
}
