using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour
{

    public GameObject balaOriginal;

    //Referencia del gameobject desde el cual se dispara
    public GameObject puntSpawn;

    // Update is called once per frame
    void Update()
    {
        //Gestionar el input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Se crea un clon de la bala

            Instantiate(balaOriginal, puntSpawn.transform.position, this.transform.rotation);
        }
        
    }
}
